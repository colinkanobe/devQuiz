namespace SuperHeroSpeedNetworking.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    using SuperHeroSpeedNetworking.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        [HttpPost]
        [Route("~/api/[controller]/Save")]
        public ActionResult Save(EventModel model)
        {
            // INSERT CODE TO SAVE
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // INSERT CODE TO SAVE
            throw new NotImplementedException();
        }

    }
}
