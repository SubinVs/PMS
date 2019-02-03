using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Core.Interfaces.HMS;

namespace Hms.Api.Controllers
{
    [RoutePrefix("api/Floor")]
    public class FloorController : ApiController
    {
        private IFloorManager _floorManager = null;
        public FloorController(IFloorManager floorManager)
        {
            this._floorManager = floorManager;
        }

        [HttpGet]
        [Route("GetAllFloor")]
        public IHttpActionResult GetAllFloor() => Ok(_floorManager.GetAll());
    }
}
