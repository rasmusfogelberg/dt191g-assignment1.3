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
      try
      {
           var response = await httpClient.GetFromJsonAsync<FilmsResponse>("/api/films");
           return response;
      }
      catch (HttpRequestException)
      {
        Console.WriteLine("An error occurred");
      }
      return null;
    }

    public async Task<Film?> getFilm(string url)
    {
      try
      {
           var response = await httpClient.GetFromJsonAsync<Film>(url);
           return response;
      }
      catch (HttpRequestException)
      {
        Console.WriteLine("An error occurred");
      }
      return null;
    }
  }
}