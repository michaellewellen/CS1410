
using System.Net.Http.Json;

var httpClient = new HttpClient { BaseAddress = new Uri("https://snow-rover.azurewebsites.net") };
string gameId = Console.ReadLine();
string name = Console.ReadLine();
var response = await httpClient.GetAsync($"/game/join?gameId={gameId}&name={name}");

var joinResponse = await response.Content.ReadFromJsonAsync<JoinResponse>();

//hang on to these for later
int ingenuityX = joinResponse.StartingX;
int ingenuityY = joinResponse.StartingY;

public class Neighbor
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Difficulty { get; set; }
}

public class LowResolutionCell
{
    public int LowerLeftX { get; set; }
    public int LowerLeftY { get; set; }
    public int UpperRightX { get; set; }
    public int UpperRightY { get; set; }
    public int AverageDifficulty { get; set; }
}