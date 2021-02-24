using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1Web.Database;
using Lab1Web.Enitites;
using Lab1Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ExchangesDbContext _dbContext;

        public CompanyController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            var entity = new ItemEntity
            {
                Name = company.Name,
                Description = company.Description,
                IsVisible = company.IsVisible
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();
            return RedirectToAction("CompanyAdded", new { itemId = entity.Id });
        }

        [HttpGet]
        public IActionResult CompanyAdded(int itemId)
        {
            return View(itemId);
        }
    }
}
