using HomeApp.Models.Configuration;
using HomeApp.Models.Domain.Movies;
using HomeApp.Helpers;
using RestSharp;

namespace HomeApp.Data.Radarr {
    public class RadarrMovieLibraryService : IMovieLibraryService {

        private const string ApiPath = "/api/v3";

        private readonly IServiceConfiguration _serviceConfiguration;
        public RadarrMovieLibraryService(IServiceConfiguration serviceConfiguration) {
            _serviceConfiguration = serviceConfiguration;
        }

        public Task<List<Movie>> GetLibrary() {
            return RestClientHelper.Get<List<Movie>>(_serviceConfiguration.Api.RadarrUrl,  ApiPath + "/movie", _serviceConfiguration.Api.RadarrApiKey);   
        } 
    }
}