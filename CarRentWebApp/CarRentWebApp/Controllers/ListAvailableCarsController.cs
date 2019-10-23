using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentWebApp.Controllers
{
    public class ListAvailableCarsController : Controller
    {
        private readonly academy_netContext _context;

        public ListAvailableCarsController(academy_netContext context)
        {
            _context = context;
        }

        // GET: CarRents
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["CarId"] = sortOrder == "carId" ? "carId_desc" : "carId";

            ViewData["Plate"] = sortOrder == "plate" ? "plate_desc" : "plate";

            ViewData["Manufacturer"] = sortOrder == "manufacturer" ? "manufacturer_desc" : "manufacturer";

            ViewData["Model"] = sortOrder == "model" ? "model_desc" : "model";

            ViewData["PricePerDay"] = sortOrder == "pricePerDay" ? "pricePerDay_desc" : "pricePerDay";

            var contents = from x in _context.Cars select x;

            switch (sortOrder)
            {
                case "pricePerDay":
                contents = contents.OrderBy(x => x.PricePerDay);
                break;

                case "pricePerDay_desc":
                contents = contents.OrderByDescending(x => x.PricePerDay);
                break;

                case "model":
                contents = contents.OrderBy(x => x.Model);
                break;

                case "model_desc":
                contents = contents.OrderByDescending(x => x.Model);
                break;

                case "manufacturer":
                contents = contents.OrderBy(x => x.Manufacturer);
                break;

                case "manufacturer_desc":
                contents = contents.OrderByDescending(x => x.Manufacturer);
                break;

                case "plate":
                contents = contents.OrderBy(x => x.Plate);
                break;

                case "plate_desc":
                contents = contents.OrderByDescending(x => x.Plate);
                break;

                case "carId_desc":
                contents = contents.OrderByDescending(x => x.CarId);
                break;

                default:
                contents = contents.OrderBy(x => x.CarId);
                break;
            }

            return View(await contents.AsNoTracking().ToListAsync());
        }
    }
}