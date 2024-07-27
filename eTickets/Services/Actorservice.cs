using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Services;

public class ActorService : IActorService
{
    private readonly AppDBContext _context;

    public ActorService(AppDBContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Actor>> GetActorsAsync()
    {
        var list = await _context.Actors.ToListAsync();
        return list;
    }

    public async Task<Actor> CreateActorAsync(Actor actor)
    {
        if (actor == null)
        {
            throw new ArgumentNullException(nameof(actor));
        }

        if (string.IsNullOrEmpty(actor.FullName))
        {
            throw new ArgumentException("Actor full name is required.");
        }

        await _context.Actors.AddAsync(actor);
        await _context.SaveChangesAsync();
        return actor;
    }

    public Actor GetById(int id)
    {
        var actor = _context.Actors
            .Include(a => a.Actor_Movies)
            .FirstOrDefault(ac => ac.Id == id);

        if (actor == null)
        {
            throw new KeyNotFoundException($"Actor with ID {id} not found.");
        }

        return actor;
    }

    public Actor UpdateActor(Actor actor)
    {
        throw new NotImplementedException();
    }

    public bool DeleteActor(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Actor> SearchActors(string searchTerm)
    {
        throw new NotImplementedException();
    }
}