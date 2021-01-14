namespace SuperHeroSpeedNetworking.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using System.Web;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Hosting.Internal;
    using Newtonsoft.Json;
    using SuperHeroSpeedNetworking.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public EventsController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        [Route("~/api/[controller]/Match")]
        public ActionResult Match(string id)
        {
            var allEvents = this.GetAllEvents();
            var thisEvent = allEvents.FirstOrDefault(evt => evt.Id == id);
            return new JsonResult(this.GenerateMeetings(thisEvent));
        }

        [HttpGet]
        [Route("~/api/[controller]")]
        public ActionResult Get(string id)
        {
            var allEvents = this.GetAllEvents();
            var thisEvent = allEvents.FirstOrDefault(evt => evt.Id == id);
            return new JsonResult(thisEvent);
        }

        private List<EventModel> GetAllEvents()
        {
            var fileContents = System.IO.File.ReadAllText($"{this.webHostEnvironment.ContentRootPath}/Data/Events.json");
            return JsonConvert.DeserializeObject<List<EventModel>>(fileContents);
        }

        private EventModel GenerateMeetings(EventModel eventModel)
        {
            throw new NotImplementedException();
        }
    }
}