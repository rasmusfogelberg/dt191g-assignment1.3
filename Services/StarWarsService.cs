using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Net.Http.Json;

public class StarWarsService : IStarWarsService
{
  readonly HttpClient httpClient;

  public StarWarsService(HttpClient _httpClient)
  {
    httpClient = _httpClient;
  }

  public async Task<Film[]?> getFilms()
  {
    return await httpClient.GetFromJsonAsync<Film[]>("api/films");
  }
}