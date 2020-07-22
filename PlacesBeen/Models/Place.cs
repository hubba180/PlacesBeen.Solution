using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    private static List<Place> _instances = new List<Place> {};
    
    public string CityName { get; }
    public string Description { get; set; }
    public int Id { get; } = 0;

    public Place(string cityName, string description)
    {
      CityName = cityName;
      Description = description;
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