using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using VehicleApi.Dao;

namespace VehicleApi.Controllers
{
    
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        // POST api
      
        [HttpPost]
        public ActionResult<ProcessVehicleResponse> ProcessVehicle([FromBody]VehicleRequest vehicleRequest)
        {
            ProcessVehicleResponse processVehicleResponse;
           

            if (!ModelState.IsValid)

            {
                processVehicleResponse = new ProcessVehicleResponse(0, VehicleValidationResultCode.Invalid);
              
               
            }
            else
            {
                processVehicleResponse = new ProcessVehicleResponse(vehicleRequest.VehicleId, VehicleValidationResultCode.Valid);
                
            }

            return processVehicleResponse;

        }
      
    }
}
