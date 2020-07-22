using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    private static List<Place> _instances = new List<Place> {};
    public string CityName { get; }

    public Place(string cityName)
    {
      CityName = cityName;
      _instances.Add(this);
    }
    public static List<Place> GetAll() 
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}