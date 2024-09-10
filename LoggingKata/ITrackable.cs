namespace LoggingKata
{
    public interface ITrackable
    {
        string Name { get; set; }
        Point Location { get; set; }
        double Point { get; set; }
    }
}