using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _color;
  private string _description;

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }
  public int GetPrice()
  {
    return _price;
  }

  public void SetMakeModel (string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetMiles (int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public void SetColor (string newColor)
  {
    _color = newColor;
  }
  public string GetColor()
  {
    return _color;
  }

  public void SetDescription (string newDescription)
  {
    _description = newDescription;
  }
  public string GetDescription()
  {
    return _description;
  }
}

public class Program
{
  public static void Main()
  {
    Car subaru = new Car();
    subaru.SetMakeModel("2012 Subaru Impreza");
    subaru.SetPrice(20000);
    subaru.SetMiles(67000);
    subaru.SetColor("Silver");
    subaru.SetDescription("A zippy fast boi.");

    Car bertha = new Car();
    bertha.SetMakeModel("1998 Toyota 4-Runner");
    bertha.SetPrice(2000);
    bertha.SetMiles(50000);
    bertha.SetColor("Blue");
    bertha.SetDescription("A broken piece of junk.");

    Car porsche = new Car();
    porsche.SetMakeModel("2014 Porsche 911");
    porsche.SetPrice(114991);
    porsche.SetMiles(7864);
    porsche.SetColor("Red");
    porsche.SetDescription("An overpriced tin can.");

    Car ford = new Car();
    ford.SetMakeModel("2011 Ford F450");
    ford.SetPrice(55995);
    ford.SetMiles(14241);
    ford.SetColor("White");
    ford.SetDescription("America");

    Car lexus = new Car();
    lexus.SetMakeModel("2013 Lexus RX 350");
    lexus.SetPrice(44700);
    lexus.SetMiles(20000);
    lexus.SetColor("Black");
    lexus.SetDescription("Fancy but boring.");

    Car mercedes = new Car();
    mercedes.SetMakeModel("Mercedes Benz CLS550");
    mercedes.SetPrice(39900);
    mercedes.SetMiles(37979);
    mercedes.SetColor("Orange");
    mercedes.SetDescription("Do they even have orange cars here?");

    List<Car> Cars = new List<Car>() {subaru, bertha, porsche, ford, lexus, mercedes};

    Console.WriteLine("Enter the price you want the car to be under.");
    int underPrice = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the miles you want the car to be under.");
    int underMiles = int.Parse(Console.ReadLine());

    Console.WriteLine("These cars are under $" + underPrice + " and under " + underMiles + " miles.");
    foreach(Car automobile in Cars)
    {
      if (automobile.GetPrice() < underPrice && automobile.GetMiles() < underMiles)
      {
        Console.WriteLine("Car: " + automobile.GetMakeModel());
        Console.WriteLine("Description: " + automobile.GetDescription());
        Console.WriteLine("");
      }
    }
  }
}
