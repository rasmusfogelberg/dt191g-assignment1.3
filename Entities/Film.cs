using System.Collections.Generic;

namespace RazmusBlazorWASM.Entities
{
  public class FilmsResponse
  {
    public int count { get; set; }
    public string next { get; set; } = string.Empty;
    public string previous { get; set; } = string.Empty;
    public List<Film> results { get; set; } = new List<Film>();
  }

  public class Film
  {
    public List<string> Characters { get; set; } = new List<string>();
    public DateTime Created { get; set; }
    public string Director { get; set; } = string.Empty;
    public DateTime Edited { get; set; }
    public int EpisodeId { get; set; }
    public string Opening_Crawl { get; set; } = string.Empty;
    public List<string> Planets { get; set; } = new List<string>();
    public string Producer { get; set; } = string.Empty;
    public string Release_date { get; set; } = string.Empty;
    public List<string> Species { get; set; } = new List<string>();
    public List<string> Starships { get; set; } = new List<string>();
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public List<string> Vehicles { get; set; } = new List<string>();
  }
}