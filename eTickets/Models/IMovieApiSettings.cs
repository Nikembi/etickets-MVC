using Flurl;

namespace eTickets.Models
{
    public class IMovieApiSettings
    {

        public string? BaseUrl { get; set; }
    }
  /*  var url = "https://some-api.com"
    .AppendPathSegment("endpoint")
    .SetQueryParams(new
    {
        api_key = _config.GetValue<string>("MyApiKey"),
        max_results = 20,
        q = "I'll get encoded!"
    })
    .SetFragment("after-hash");*/
}
