using System;

public class Swimming : Activity
{
  private int _laps;

  public Swimming(string date, int minutes, int laps)
      : base(date, minutes)
  {
    _laps = laps;
  }

  public override double GetDistance()
  {
    // 1 lap = 50 meters → convert to km → then to miles (0.62)
    double distanceKm = _laps * 50 / 1000.0;
    double distanceMiles = distanceKm * 0.62;
    return distanceMiles;
  }

  public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;

  public override double GetPace() => GetMinutes() / GetDistance();
}