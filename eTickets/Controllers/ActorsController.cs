using eTickets.Data;
using eTickets.Models;
using eTickets.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : Controller
    {
        private readonly IActorService _actorService;
 
        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpGet]
        public ActionResult<List<Actor>> Index()
        {
            var actors = _actorService.GetActorsAsync();
            return _actorService.GetActorsAsync();
           
        }

        // [HttpGet("CreateActor")]
        // public IActionResult Create()
        // {
        //     return View();
        // }

        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _actorService.CreateActorAsync(actor);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(actor);
        }
    }
}
