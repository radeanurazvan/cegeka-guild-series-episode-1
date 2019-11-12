using Cegeka.Guild.Pokeverse.Api.Models;
using Cegeka.Guild.Pokeverse.BLL.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Cegeka.Guild.Pokeverse.Api.Controllers
{
    [Route("api/trainers")]
    public class TrainersController : ControllerBase
    {
        private readonly ITrainerService trainersService;

        public TrainersController(ITrainerService trainersService)
        {
            this.trainersService = trainersService;
        }

        [HttpPost("")]
        public IActionResult Register([FromBody]RegisterTrainerModel model)
        {
            this.trainersService.Register(model.Name);
            return Ok();
        }
    }
}