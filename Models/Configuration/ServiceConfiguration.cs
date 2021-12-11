namespace HomeApp.Models.Configuration {
    public class ServiceConfiguration : IServiceConfiguration {
       
        public ApiConfiguration Api {get;set;} = new ApiConfiguration {
            RadarrApiKey = "2747738a76f345bc9dab704cc95f8535",
            RadarrUrl = "http://mediapc:7878"
        };
    }
}