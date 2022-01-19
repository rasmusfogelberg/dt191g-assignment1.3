using RazmusBlazorWASM.Entities;

namespace RazmusBlazorWASM.Services
{
  public interface IStarWarsService
  {
    Task<FilmsResponse?> getFilms();

    Task<Film?> getFilm(string url);
  }
}