using HomeApp.Models.Domain.Movies;

namespace HomeApp.Data {

    public interface IMovieLibraryService {
        
        Task<List<Movie>> GetLibrary();
    }


}