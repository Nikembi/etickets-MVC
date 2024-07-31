using eTickets.Models;

namespace eTickets.Services;

public interface IActorService
{
    Task<IEnumerable<Actor>> GetActorsAsync();
    Task<Actor> CreateActorAsync(Actor actor);
    Actor GetById(int id);
    Actor UpdateActor(Actor actor);
    bool DeleteActor(int id);
    IEnumerable<Actor> SearchActors(string searchTerm);
}