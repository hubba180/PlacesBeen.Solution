namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName { get; }

    public Place(string cityName)
    {
      CityName = cityName;
    }
  }
}