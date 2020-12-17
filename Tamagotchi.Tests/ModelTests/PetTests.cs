using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.TestTools
{
  [TestClass]
  public class PetTests
  {
    [TestMethod]
    public void PetConstructor_CreatesInstanceOfPet_Pet()
    {
      Pet gigaPet = new Pet("Brownie");
      Assert.AreEqual(typeof(Pet), gigaPet.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      //Arrange
      string name = "Brownie";
      Pet gigaPet = new Pet(name);
      //Act
      string result = gigaPet.Name;
      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void Time_ReturnReducedFoodAttentionRest_int()
    {
      //Arrange
      Pet gigaPet2 = new Pet("Rowdy");
      //Act
      Pet result = gigaPet2.Time();
      int food = result.Food;
      int attention = result.Attention;
      int rest = result.Rest;
      //Assert
      Assert.AreEqual(food, gigaPet2.Food);
      Assert.AreEqual(attention, gigaPet2.Attention);
      Assert.AreEqual(rest, gigaPet2.Rest);
    }
  }
}