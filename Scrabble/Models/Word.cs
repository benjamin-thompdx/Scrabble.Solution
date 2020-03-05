using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Word 
  {
    public static Dictionary<char, int> scrabbleDictionary {get; set;} = new Dictionary<char, int>()
    {
      {'a', 1},{'e', 1},{'i', 1},{'o', 1},{'u', 1},{'l', 1},{'n', 1},{'r', 1},{'s', 1},{'t', 1},{'d', 2},{'g', 2},{'b', 3},{'c', 3},{'m', 3},{'p', 3},{'f', 4},{'h', 4},{'v', 4},{'w', 4},{'y', 4},{'k', 5},{'j', 8},{'x', 8},{'q', 10},{'z', 10}
    };

    public static string wordList = System.IO.File.ReadAllText(@"/Users/Guest/Desktop/Scrabble.Solution/Scrabble/Models/WordList.txt");

    public static char[] WordToChar(string userInput)
    {
      char[] userInputArray = userInput.ToCharArray();
      return userInputArray;
    }

    public static int CheckWordScore(char[] userArray)
    {
      int totalScore = 0;
      foreach (char letter in userArray)
      {
        int letterValue = scrabbleDictionary[letter];
        totalScore +=letterValue;     
      }
      return totalScore;
    }

  public static bool IsAWord(string userInput)
  {
    return false;
  }
  }
}