using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Interface
{
    public interface IMovieData
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        DbSet<User> Users { get; }
        DbSet<Actor> Actors { get; }
        DbSet<Actor_Movie> Actor_Movies { get; }
        DbSet<Cinemas> Cinemas { get; }
        DbSet<Movies> Movies { get; }
        DbSet<Producer> Producers { get; }
    }
}
