using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebServiceData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServiceData.Controllers
{
    [Route("api/")]
    [ApiController]
    public class MongoDBController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        [Route("GetAllPlants")]
        public async Task<JsonResult> Get()
        {
            var monogDbService = new MongoDBMain("Project", "PlantProfiles", @"mongodb+srv://Llamaxy:865feeBA@test-i10mg.mongodb.net/test?retryWrites=true");
            var allPlantsProfiles = await monogDbService.GetAllPlantsProfiles();
            return Json(allPlantsProfiles);   
        }

        // POST api/<controller>
        [HttpPost]
        public async void Post([FromBody]PlantProfile account)
        {
            var monogDbService = new MongoDBMain("AccountsDatabase", "PlantProfiles", "mongodb://ea9d9986e87a086f47cf3eedf97735a3");

            await monogDbService.InsertAccount(account);
        }

    }
}
