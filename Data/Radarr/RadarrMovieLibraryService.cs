using HomeApp.Models.Configuration;
using HomeApp.Models.Domain.Movies;
using HomeApp.Helpers;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text.Encodings.Web;

namespace HomeApp.Data.Radarr {
    public class RadarrMovieLibraryService : IMovieLibraryService {

        private const string ApiPath = "/api/v3";
        private UrlEncoder _urlEncoder = UrlEncoder.Default;

        private readonly IServiceConfiguration _serviceConfiguration;
        public RadarrMovieLibraryService(IServiceConfiguration serviceConfiguration) {
            _serviceConfiguration = serviceConfiguration;
        }

        public Task<List<Movie>> GetLibrary() {
            return RestClientHelper.Get<List<Movie>>(_serviceConfiguration.Api.RadarrUrl, ConstructUrl("/movie") );
        }

        public Task<List<Movie>> GetMovie(int tmdbId)
        {
            return RestClientHelper.Get<List<Movie>>(_serviceConfiguration.Api.RadarrUrl, ConstructUrl("/movie", new Dictionary<string, string> { { "tmdbId", tmdbId.ToString() } }));
        }

        public Task<List<Movie>> AddMovie(Movie movie)
        {
            return RestClientHelper.Post<List<Movie>>(_serviceConfiguration.Api.RadarrUrl, ConstructUrl("/movie"), movie);
        }

        public Task<List<Movie>> Search(string searchPhrase)
        {
            return RestClientHelper.Get<List<Movie>>(_serviceConfiguration.Api.RadarrUrl, ConstructUrl("/movie/lookup", new Dictionary<string, string> { { "term", searchPhrase } }));
        }

        public Task<List<Movie>> GetQueue()
        {
            return RestClientHelper.Get<List<Movie>>(_serviceConfiguration.Api.RadarrUrl, ConstructUrl("/queue"));
        }


        private string ConstructUrl(string resource, Dictionary<string,string> urlParameters = null)
        {
            string url = ApiPath + resource;
            if (urlParameters == null) urlParameters = new();

            urlParameters.Add("apiKey", _serviceConfiguration.Api.RadarrApiKey);           
            
            return url + "?" + string.Join('&', urlParameters.Select(kvp => _urlEncoder.Encode(kvp.Key) + "=" + _urlEncoder.Encode(kvp.Value)));
        }
    }
}