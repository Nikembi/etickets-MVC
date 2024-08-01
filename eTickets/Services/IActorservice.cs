using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Services;

public interface IActorService
{
    ActionResult<List<Actor>> GetActorsAsync();
    Task<Actor> CreateActorAsync(Actor actor);
    Actor GetById(int id);
    Actor UpdateActor(Actor actor);
    bool DeleteActor(int id);
    IEnumerable<Actor> SearchActors(string searchTerm);
}