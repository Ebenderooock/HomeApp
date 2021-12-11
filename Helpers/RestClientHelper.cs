using RestSharp;
using System.Threading;

namespace HomeApp.Helpers {

    public static class RestClientHelper {

        private static RestClient GetClient(string baseUrl) {
            return new RestClient(baseUrl);
        }

        private static IRestRequest CreateRequest(string resource, string apiKey = "") {
            return new RestRequest($"{resource}{ (string.IsNullOrEmpty(apiKey) ? "" : "?apiKey=" + apiKey) }");
        }

        public static Task<T> Get<T>(string baseUrl, string resource, string apiKey = "") {
            return GetClient(baseUrl).GetAsync<T>(CreateRequest(resource, apiKey));
        }

        

    }

}