using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTestValidationFilter.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1
{
    [Route("api/[controller]")][ApiController]
    public class ModelAController : Controller
    {

        public ModelAController()
        {
            models = new List<ModelA>() { new ModelA() { ModelNumber = 1, ModelName = "Modela1" },
                                        new ModelA() { ModelNumber = 2, ModelName = "Modela2" } };
        }
         private List<ModelA> models;
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ModelA> Get()
        {
            return models;
        }

        [HttpGet("{id}")]
        public ModelA Get(int id)
        {
            return models[id];
        }

        [HttpPost]
        public void Post(ModelA model)
        {
        }


    }
}
