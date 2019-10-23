using System;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using CarRentWebApp.Models;
using CarRentWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentWebApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly academy_netContext _context;

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        IdentityResult identityResult = new IdentityResult();

        public CustomersController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager,academy_netContext context)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        // GET: CustomerList
        public async Task<IActionResult> Index(string sortOrder, string search)
        {
            ViewData["CostumerId"] = sortOrder == "costumerId" ? "costumerId_desc" : "costumerId";

            ViewData["Name"] = sortOrder == "name" ? "name_desc" : "name";

            ViewData["BirthDate"] = sortOrder == "birthDate" ? "birthDate_desc" : "birthDate";

            ViewData["Location"] = sortOrder == "location" ? "location_desc" : "location";

            var contents = from x in _context.Customers select x;

            if (!String.IsNullOrEmpty(search))
            {
                contents = contents.Where(customer => customer.Name.StartsWith(search) || customer.BirthDate.ToString().StartsWith(search) ||
                customer.Location.StartsWith(search) || customer.CostumerId.ToString().StartsWith(search));
            }

            switch (sortOrder)
            {
                case "location":
                contents = contents.OrderBy(x => x.Location);
                break;

                case "location_desc":
                contents = contents.OrderByDescending(x => x.Location);
                break;

                case "birthDate":
                contents = contents.OrderBy(x => x.BirthDate);
                break;

                case "birthDate_desc":
                contents = contents.OrderByDescending(x => x.BirthDate);
                break;

                case "name":
                contents = contents.OrderBy(x => x.Name);
                break;

                case "name_desc":
                contents = contents.OrderByDescending(x => x.Name);
                break;

                case "costumerId_desc":
                contents = contents.OrderByDescending(x => x.CostumerId);
                break;

                default:
                contents = contents.OrderBy(x => x.CostumerId);
                break;
            }

            return View(await contents.AsNoTracking().ToListAsync());
        }


        public ActionResult CustomersByCount()
        {
            var customerCount = _context.Customers.GroupBy(x => x.Name)
            .Select(y => new CustomersCount { Name = y.Key, Total = y.Count() }).ToList().OrderByDescending(y => y.Total);

            return View(customerCount);
        }

        // GET: Customers/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FirstOrDefaultAsync(m => m.CostumerId == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CostumerId,Name,BirthDate,Location,Password,ConfirmPassword")] Customers customers)
        {

            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: customers.Password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));


            if (ModelState.IsValid)
            {
                var customer = new IdentityUser { UserName = customers.Name };
                var result = await userManager.CreateAsync(customer, customers.Password);

                if (result.Succeeded)
                {
                    customers.Password = hashed;
                    customers.ConfirmPassword = hashed;
                    _context.Add(customers);

                    await signInManager.SignInAsync(customer, isPersistent: false);

                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(customers);
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            return View(customers);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("CostumerId,Name,BirthDate,Location,Password,ConfirmPassword")] Customers customers)
        {
            if (id != customers.CostumerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await userManager.Users.FirstOrDefaultAsync(m => m.UserName == customers.Name);
                    var userName = await userManager.FindByNameAsync(user.UserName);

                    identityResult = await userManager.UpdateAsync(userName);
                    _context.Update(customers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customers.CostumerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customers);
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync(m => m.CostumerId == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customers = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customers);

            _context.CarRent.RemoveRange(_context.CarRent.Where(m => m.ClientID == id));

            var user = await userManager.Users.FirstOrDefaultAsync(m => m.UserName == customers.Name);
            var userName = await userManager.FindByNameAsync(user.UserName);

            identityResult = await userManager.DeleteAsync(userName);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CostumerId == id);
        }
    }
}