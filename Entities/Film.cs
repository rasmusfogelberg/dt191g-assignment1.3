using System.Text.Json.Serialization;

public class FilmsResponse
{
  public int count { get; set; }
  public string next { get; set; }
  public string previous { get; set; }
  public List<Film> results { get; set; }
}

public class Film
  {
    public List<string?> Characters { get; set; }
    public DateTime? Created { get; set; }
    public string? Director { get; set; }
    public DateTime? Edited { get; set; }
    public int EpisodeId { get; set; }
    public string? Opening_Crawl { get; set; }
    public List<string?> Planets { get; set; }
    public string? Producer { get; set; }
    public string? Release_date { get; set; }
    public List<string?> Species { get; set; }
    public List<string?> Starships { get; set; }
    public string? Title { get; set; }
    public string? Url { get; set; }
    public List<string?> Vehicles { get; set; }

  }