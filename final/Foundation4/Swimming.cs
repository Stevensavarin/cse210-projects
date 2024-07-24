using System;

public class Swimming : Activity
{
    private int _laps { get; set; }

    public Swimming(double length, int laps) : base(length)
    {
        _laps = laps;
    }

        public override double CalculateDistance()
    {
        double distance =  Math.Round(_laps * 50 / 1000 * 0.62, 1);
        return distance;
    }

    public override double CalculateSpeed()
    {
        double speed = Math.Round((CalculateDistance() / GetLength()) * 60, 1);
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = Math.Round(GetLength() / CalculateDistance(), 1);
        return pace;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()} min) - Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()}, Pace: {CalculatePace()} min per mile");
    }
}