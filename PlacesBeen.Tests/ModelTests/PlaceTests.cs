using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PlacesBeen.Models;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTest : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Portland", "So much beer!");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Portland";

      Place newPlace = new Place("Portland", "So much beer!");
      string result = newPlace.CityName;

      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_List()
    {
      List<Place> testList = Place.GetAll();
      List<Place> result = new List<Place> {};
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "So much beer!";
      Place newPlace = new Place("Portland", description);
      string result = newPlace.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "so much beer";
      Place newPlace = new Place("Portland", description);
      string update = "too much beer";
      newPlace.Description = update;
      string result = newPlace.Description;
      Assert.AreEqual(update, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      string cityName = "Portland";
      string description = "So much beer!";
      Place newPlace = new Place(cityName, description);

      int result = newPlace.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_GrabsPlaceObjectByIDFromStaticList_Place()
    {
      string cityName = "Portland";
      string description = "So much beer!";
      Place newPlace = new Place(cityName, description);
      Place result = Place.Find(1);
      Assert.AreEqual(newPlace, result);
    }
  }
}