using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentWebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace CarRentWebApp.Controllers
{
    public class CarRentsController : Controller
    {
        private readonly academy_netContext _context;

        public CarRentsController(academy_netContext context)
        {
            _context = context;
        }

        // GET: CarList
        public async Task<IActionResult> Index(string sortOrder, string search)
        {
            ViewData["ClientID"] = sortOrder == "clientID" ? "clientID_desc" : "clientID";

            ViewData["StartDate"] = sortOrder == "startDate" ? "startDate_desc" : "startDate";

            ViewData["EndDate"] = sortOrder == "endDate" ? "endDate_desc" : "endDate";

            ViewData["CarModel"] = sortOrder == "carModel" ? "carModel_desc" : "carModel";

            ViewData["City"] = sortOrder == "city" ? "city_desc" : "city";

            ViewData["CurrentFilter"] = search;

            var contents = from x in _context.CarRent select x;

            if (!String.IsNullOrEmpty(search))
            {
                contents = contents.Where(car => car.CarModel.StartsWith(search) || car.ClientID.ToString().StartsWith(search) ||
                car.City.StartsWith(search) || car.StartDate.ToString().StartsWith(search) || car.EndDate.ToString().StartsWith(search));
            }

            switch (sortOrder)
            {
                case "carModel":
                contents = contents.OrderBy(x => x.CarModel);
                break;

                case "carModel_desc":
                contents = contents.OrderByDescending(x => x.CarModel);
                break;

                case "startDate":
                contents = contents.OrderBy(x => x.StartDate);
                break;

                case "startDate_desc":
                contents = contents.OrderByDescending(x => x.StartDate);
                break;

                case "endDate":
                contents = contents.OrderBy(x => x.EndDate);
                break;

                case "endDate_desc":
                contents = contents.OrderByDescending(x => x.EndDate);
                break;

                case "clientID_desc":
                contents = contents.OrderByDescending(x => x.ClientID);
                break;

                case "city":
                contents = contents.OrderBy(x => x.City);
                break;

                case "city_desc":
                contents = contents.OrderByDescending(x => x.City);
                break;

                default:
                contents = contents.OrderBy(x => x.ClientID);
                break;
            }

            return View(await contents.AsNoTracking().ToListAsync());
        }


        public ActionResult CarRentsByCount()
        {
            var carRentCount = _context.CarRent.GroupBy(x => x.CarModel)
            .Select(y => new CarRentCount { Name = y.Key, Total = y.Count() }).ToList().OrderByDescending(y => y.Total);

            return View(carRentCount);
        }


        // GET: CarRents/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRent = await _context.CarRent.FirstOrDefaultAsync(m => m.CarRentID == id);
            if (carRent == null)
            {
                return NotFound();
            }

            return View(carRent);
        }


        public IActionResult Create()
        {
            List<Cars> carsList = new List<Cars>();
            carsList = (from Model in _context.Cars select Model).ToList();
            carsList.Insert(0, new Cars { CarId = 0 });
            ViewBag.ListOfCars = carsList;

            List<Customers> customersList = new List<Customers>();
            List<City> citiesList = new List<City>();
            citiesList = (from CityName in _context.City select CityName).ToList();
            customersList = (from CostumerId in _context.Customers select CostumerId).ToList();
            customersList.Insert(0, new Customers { CostumerId = 0 });
            citiesList.Insert(0, new City { CityID = 0 });
            ViewBag.ListOfCustomers = customersList;
            ViewBag.ListOfCities = citiesList;

            return View();
        }
         

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarRentID,ClientID,CarModel,StartDate,EndDate,City")] CarRent carRent)
        {
             if (ModelState.IsValid)
             {
                 DateTime startDate = carRent.StartDate;
                 DateTime endDate = carRent.EndDate;
                 int clientID = carRent.ClientID;

                 if (startDate > endDate || clientID == 0)
                 {
                    return RedirectToAction(nameof(Create));
                 }
                 else
                 {
                     _context.Add(carRent);
                     await _context.SaveChangesAsync();
                     return RedirectToAction(nameof(Index));
                 }
             }
            return View(carRent);
        }


        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            List<Cars> carsList = new List<Cars>();
            carsList = (from Model in _context.Cars select Model).ToList();
            carsList.Insert(0, new Cars { CarId = 0 });
            ViewBag.ListOfCars = carsList;

            List<Customers> customersList = new List<Customers>();
            customersList = (from Location in _context.Customers select Location).ToList();
            customersList.Insert(0, new Customers { CostumerId = 0 });
            ViewBag.ListOfCustomers = customersList;

            if (id == null)
            {
                return NotFound();
            }

            var carRent = await _context.CarRent.FindAsync(id);
            if (carRent == null)
            {
                return NotFound();
            }
            return View(carRent);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit([Bind("CarRentID,ClientID,CarModel,StartDate,EndDate,City")] CarRent carRent)
        {
            if (ModelState.IsValid)
            {
                DateTime startDate = carRent.StartDate;
                DateTime endDate = carRent.EndDate;
                int clientIDEdit = carRent.ClientID;

                if (startDate > endDate || clientIDEdit == 0)
                {
                    return RedirectToAction(nameof(Edit));
                }
                else
                {
                    _context.Update(carRent);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(carRent);
        }

        // GET: CarRents/Delete
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRent = await _context.CarRent.FirstOrDefaultAsync(m => m.CarRentID == id);
            if (carRent == null)
            {
                return NotFound();
            }

            return View(carRent);
        }

        // POST: CarRents/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carRent = await _context.CarRent.FindAsync(id);
            _context.CarRent.Remove(carRent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarRentExists(int id)
        {
            return _context.CarRent.Any(e => e.CarRentID == id);
        }
    }
}
