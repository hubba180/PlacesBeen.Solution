using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    private static List<Place> _instances = new List<Place> {};
    
    public string CityName { get; }
    public string Description { get; set; }
    public int Id { get; }

    public Place(string cityName, string description)
    {
      CityName = cityName;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Place> GetAll() 
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int id)
    {
      return _instances[id - 1];
    }
  }
}