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
  }
}