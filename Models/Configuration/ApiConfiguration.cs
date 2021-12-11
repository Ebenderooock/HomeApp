namespace HomeApp.Models.Configuration {
    public class ApiConfiguration {
        public string RadarrApiKey {get;set;} = "";
        public string RadarrUrl {get;set;}  = "";

        public string SonarrApiKey {get;set;}  = "";
        public string SonarrUrl {get;set;}  = "";

        public string PlexApiKey {get;set;}  = "";
        public string PlexUrl {get;set;}  = "";

        public List<string> MoviesPaths = new List<string>();
        public List<string> TVShowsPaths  = new List<string>();
    }
}