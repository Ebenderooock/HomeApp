using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace HomeApp.Helpers {

    public static class RestClientHelper {

        private static RestClient GetClient(string baseUrl) {
            return new RestClient(baseUrl);
        }

        private static IRestRequest CreateRequest(string resource) {
            return new RestRequest($"{resource}");
        }

        public static Task<TResponse> Get<TResponse>(string baseUrl, string resource) {
            return GetClient(baseUrl).GetAsync<TResponse>(CreateRequest(resource));
        }
        
        public static Task<TResponse> Post<TResponse> (string baseUrl, string resource, object payload)
        {
            return GetClient(baseUrl).PostAsync<TResponse>(CreateRequest(resource).AddJsonBody(payload));
        }
    }

}