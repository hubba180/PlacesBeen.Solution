using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesBeen.Models;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTest
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Portland");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Portland";

      Place newPlace = new Place("Portland");
      string result = newPlace.CityName;

      Assert.AreEqual(cityName, result);
    }
  }
}