
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Test
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void Dictionary_VerifyObjectWithinDictionary_CharInt()
    {
      //Arrange
      Dictionary<char, int> newDictionary = new Dictionary<char, int>();
      //Act
      newDictionary.Add ('a', 1);
      int points = newDictionary['a'];
      //Assert
      Assert.AreEqual(1, points);
    }
  }

}