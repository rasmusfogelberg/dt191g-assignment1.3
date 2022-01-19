using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Net.Http.Json;
using RazmusBlazorWASM.Entities;

namespace RazmusBlazorWASM.Services
{
  public class StarWarsService : IStarWarsService
  {
    readonly HttpClient httpClient;

    public StarWarsService(HttpClient _httpClient)
    {
      httpClient = _httpClient;
    }

    public async Task<FilmsResponse?> getFilms()
    {
      return await httpClient.GetFromJsonAsync<FilmsResponse>("/api/films");
    }

    public async Task<Film?> getFilm(string url)
    {
      return await httpClient.GetFromJsonAsync<Film>(url);
    }
  }
}