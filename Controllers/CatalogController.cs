using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreServiceBroker.Models;
using Newtonsoft.Json;

namespace NetCoreServiceBroker.Controllers
{
    [Route("v2/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        /*
            URL: v2/Catalog

        */
        [HttpGet]
        public ActionResult<IEnumerable<Service>> Get()
        {
            return new List<Service>(){
                new Service() {
                    name = "MongoDB",
                    id = Guid.NewGuid().ToString(),
                    description = "MongoDB Service",
                    tags = new List<string>() { "MongoDB" },
                    requires = new List<string>(),
                    bindable = true,
                    metadata = new JsonToken(),
                    dashboard_client = null,
                    plan_updateable = false,
                    plans = new List<ServicePlan>() {
                        new ServicePlan() {
                            id = Guid.NewGuid().ToString(),
                            name = "Basic Plan",
                            description = "The basic MongoDB plan",
                            metadata = false,
                            free = true,
                            bindable = true,
                            schemas = null
                        }
                    }
                }
            };
        }
    }
}
