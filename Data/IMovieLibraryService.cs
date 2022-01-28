using HomeApp.Models.Domain.Movies;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeApp.Data {

    public interface IMovieLibraryService {
        
        Task<List<Movie>> GetLibrary();
    }


}