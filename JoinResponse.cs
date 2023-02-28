
///JoinResponse is a class like this:
public class JoinResponse
{
    public string Token { get; set; }
    public int StartingX { get; set; }
    public int StartingY { get; set; }
    public int TargetX { get; set; }
    public int TargetY { get; set; }
    public Neighbor[] Neighbors { get; set; }
    public LowResolutionCell[] LowResolutionMap { get; set; }
    public string Orientation { get; set; }
}
