using System;

public abstract class Shape
{
  private string _color;

  // Constructor
  public Shape(string color)
  {
    _color = color;
  }

  // Getter and Setter
  public string GetColor()
  {
    return _color;
  }

  public void SetColor(string color)
  {
    _color = color;
  }

  // Abstract method to calculate area (must be overridden in derived classes)
  public abstract double GetArea();
}