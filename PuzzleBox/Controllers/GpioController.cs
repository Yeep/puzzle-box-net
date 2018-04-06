using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Raspberry.IO.GeneralPurpose;

namespace PuzzleBox.Controllers
{
    [Produces("application/json")]
    [Route("api/Gpio")]
    public class GpioController : Controller
    {
        private GpioConnection m_connection;

        private static readonly PinConfiguration PIN = ProcessorPin.Pin18.Output();

        public GpioController() {
            //m_connection = new GpioConnection([ PIN ]);
        }

        [HttpPost(Name = "Open")]
        public IActionResult Open() {
            var password = Request.Form["password"];
            return new ObjectResult(new {
                password = password,
                result = "Success"
            });
        }

        [HttpPost(Name = "Close")]
        public IActionResult Close() {
            var password = Request.Form["password"];

            return new ObjectResult(new {
                password = password,
                result = "Success"
            });
        }
    }
}