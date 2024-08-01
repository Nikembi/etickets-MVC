using eTickets.Data.Interface;
using Flurl;
using Flurl.Http;
using Polly.Retry;
using Polly;
using System.Net;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class MovieData : IMovieData
    {
        private readonly IMovieApiSettings _ApiSettings;
        public MovieData(IMovieApiSettings ApiSettings)
        {
            _ApiSettings = ApiSettings;
        }
        public DbSet<Actor> Actors => throw new NotImplementedException();

        public DbSet<Actor_Movie> Actor_Movies => throw new NotImplementedException();

        public DbSet<Cinemas> Cinemas => throw new NotImplementedException();

        public DbSet<Movies> Movies => throw new NotImplementedException();

        public DbSet<Producer> Producers => throw new NotImplementedException();

        private static bool IsTransientError(FlurlHttpException exception)
        {
            int[] httpStatusCodesWorthRetrying =
            {
                (int)HttpStatusCode.RequestTimeout,
                (int)HttpStatusCode.BadGateway,
                (int)HttpStatusCode.ServiceUnavailable,
                (int)HttpStatusCode.GatewayTimeout,
                (int)HttpStatusCode.TooManyRequests,
                (int)HttpStatusCode.BadRequest
            };

            return exception.StatusCode.HasValue && httpStatusCodesWorthRetrying.Contains(exception.StatusCode.Value);
        }

        private static AsyncRetryPolicy BuildRetryPolicy()
        {
            return Policy
                .Handle<FlurlHttpException>(IsTransientError)
                .WaitAndRetryAsync(10, retryAttempt =>
                {
                    var nextAttemptIn = TimeSpan.FromSeconds(Math.Pow(2, retryAttempt));
                    Console.WriteLine($"Retry attempt {retryAttempt} to make request. Next try on {nextAttemptIn.TotalSeconds} seconds.");
                    return nextAttemptIn;
                });
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public class ChapterResponse {}
    }
}
