using Newtonsoft.Json;

namespace HomeApp.Models.Domain.Movies
{
    public class Language
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AlternateTitle
    {
        [JsonProperty("sourceType")]
        public string SourceType { get; set; }

        [JsonProperty("movieId")]
        public int MovieId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sourceId")]
        public int SourceId { get; set; }

        [JsonProperty("votes")]
        public int Votes { get; set; }

        [JsonProperty("voteCount")]
        public int VoteCount { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class Image
    {
        [JsonProperty("coverType")]
        public string CoverType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("remoteUrl")]
        public string RemoteUrl { get; set; }
    }

    public class Ratings
    {
        [JsonProperty("votes")]
        public int Votes { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class QualityProperty
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("resolution")]
        public int Resolution { get; set; }

        [JsonProperty("modifier")]
        public string Modifier { get; set; }

        [JsonProperty("quality")]
        public QualityProperty Quality { get; set; }

        [JsonProperty("revision")]
        public Revision Revision { get; set; }
    }

    public class Revision
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("real")]
        public int Real { get; set; }

        [JsonProperty("isRepack")]
        public bool IsRepack { get; set; }
    }

    public class MediaInfo
    {
        [JsonProperty("audioAdditionalFeatures")]
        public string AudioAdditionalFeatures { get; set; }

        [JsonProperty("audioBitrate")]
        public int AudioBitrate { get; set; }

        [JsonProperty("audioChannels")]
        public double AudioChannels { get; set; }

        [JsonProperty("audioCodec")]
        public string AudioCodec { get; set; }

        [JsonProperty("audioLanguages")]
        public string AudioLanguages { get; set; }

        [JsonProperty("audioStreamCount")]
        public int AudioStreamCount { get; set; }

        [JsonProperty("videoBitDepth")]
        public int VideoBitDepth { get; set; }

        [JsonProperty("videoBitrate")]
        public int VideoBitrate { get; set; }

        [JsonProperty("videoCodec")]
        public string VideoCodec { get; set; }

        [JsonProperty("videoFps")]
        public double VideoFps { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("runTime")]
        public string RunTime { get; set; }

        [JsonProperty("scanType")]
        public string ScanType { get; set; }

        [JsonProperty("subtitles")]
        public string Subtitles { get; set; }
    }


    public class MovieFile
    {
        [JsonProperty("movieId")]
        public int MovieId { get; set; }

        [JsonProperty("relativePath")]
        public string RelativePath { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public object Size { get; set; }

        [JsonProperty("dateAdded")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("indexerFlags")]
        public int IndexerFlags { get; set; }

        [JsonProperty("quality")]
        public QualityProperty Quality { get; set; }

        [JsonProperty("mediaInfo")]
        public MediaInfo MediaInfo { get; set; }

        [JsonProperty("qualityCutoffNotMet")]
        public bool QualityCutoffNotMet { get; set; }

        [JsonProperty("languages")]
        public List<Language> Languages { get; set; }

        [JsonProperty("releaseGroup")]
        public string ReleaseGroup { get; set; }

        [JsonProperty("edition")]
        public string Edition { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("originalFilePath")]
        public string OriginalFilePath { get; set; }

        [JsonProperty("sceneName")]
        public string SceneName { get; set; }
    }

    public class Collection
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tmdbId")]
        public int TmdbId { get; set; }

        [JsonProperty("images")]
        public List<object> Images { get; set; }
    }

    public class Movie
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("originalTitle")]
        public string OriginalTitle { get; set; }

        [JsonProperty("alternateTitles")]
        public List<AlternateTitle> AlternateTitles { get; set; }

        [JsonProperty("secondaryYearSourceId")]
        public int SecondaryYearSourceId { get; set; }

        [JsonProperty("sortTitle")]
        public string SortTitle { get; set; }

        [JsonProperty("sizeOnDisk")]
        public object SizeOnDisk { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("digitalRelease")]
        public DateTime DigitalRelease { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("hasFile")]
        public bool HasFile { get; set; }

        [JsonProperty("youTubeTrailerId")]
        public string YouTubeTrailerId { get; set; }

        [JsonProperty("studio")]
        public string Studio { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("qualityProfileId")]
        public int QualityProfileId { get; set; }

        [JsonProperty("monitored")]
        public bool Monitored { get; set; }

        [JsonProperty("minimumAvailability")]
        public string MinimumAvailability { get; set; }

        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("folderName")]
        public string FolderName { get; set; }

        [JsonProperty("runtime")]
        public int Runtime { get; set; }

        [JsonProperty("cleanTitle")]
        public string CleanTitle { get; set; }

        [JsonProperty("imdbId")]
        public string ImdbId { get; set; }

        [JsonProperty("tmdbId")]
        public int TmdbId { get; set; }

        [JsonProperty("titleSlug")]
        public string TitleSlug { get; set; }

        [JsonProperty("genres")]
        public List<string> Genres { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("added")]
        public DateTime Added { get; set; }

        [JsonProperty("ratings")]
        public Ratings Ratings { get; set; }

        [JsonProperty("movieFile")]
        public MovieFile MovieFile { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("inCinemas")]
        public DateTime? InCinemas { get; set; }

        [JsonProperty("physicalRelease")]
        public DateTime? PhysicalRelease { get; set; }

        [JsonProperty("certification")]
        public string Certification { get; set; }

        [JsonProperty("collection")]
        public Collection Collection { get; set; }

        [JsonProperty("secondaryYear")]
        public int? SecondaryYear { get; set; }


        public string PosterUrl => Images?.FirstOrDefault(image => image.CoverType == "poster")?.RemoteUrl;

        public string DisplayStatus
        {
            get
            {
                string status = "";

                if (Status == MovieStatus.RELEASED)
                {
                    if (HasFile)
                    {
                        status = MovieDisplayStatus.DOWNLOADED;
                    }
                    else if (IsAvailable)
                    {
                        status = MovieDisplayStatus.DOWNLOADABLE;
                    }
                }
                else
                {
                    status = MovieDisplayStatus.UNAVAILABLE;
                }


                return status;
            }
        }
    }
}