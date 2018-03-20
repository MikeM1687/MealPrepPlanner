using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealPrepPlanner.Entities;
using MealPrepPlanner.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeapPrepPlanner.Api.Controllers
{
    [Route("api/[controller]")]
    public class MealPrepPlannerController : Controller
    {
        private readonly IDataService _dataService;

        public MealPrepPlannerController(IDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var meals = _dataService.GetMeals();

                return Ok(meals.ToList());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
