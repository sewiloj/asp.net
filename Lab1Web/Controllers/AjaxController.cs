using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1Web.Database;
using Lab1Web.Enitites;
using Lab1Web.Models;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace Lab1Web.Controllers
{
    [ApiController]
    [Route("api/ajax")]
    public class AjaxController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;

        public AjaxController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Ajax Post(CompanyModel company)
        {
            var entity = new ItemEntity
            {
                Name = company.Name,
                Description = company.Description,
                IsVisible = company.IsVisible
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();


            return new Ajax
            {
                Success = true
            };
        }

    }
}
