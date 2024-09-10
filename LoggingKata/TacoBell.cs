namespace LoggingKata;

public class TacoBell : ITrackable
{
    public string Name { get; set; }
    public Point Location { get; set; }
    public double Point { get; set; }

    public object GetDistanceTo(TacoBell locB)
    {
        throw new System.NotImplementedException();
    }
}