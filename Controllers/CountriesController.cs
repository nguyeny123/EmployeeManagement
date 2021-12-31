using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly AppDbContext db = null;

        public CountriesController(AppDbContext db)
        {
            this.db = db;
        }


        [HttpGet]
        public async Task<List<Country>> GetAsync()
        {
            List<Country> countries = await db.Countries.ToListAsync();
            return countries;
        }
    }
}
