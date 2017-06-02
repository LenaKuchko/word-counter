using System;
using System.Collections.Generic;
using Xunit;
using WordCounter;

namespace WordCounter
{
  public class WordCounterTests
  {
    [Fact]
    public void Convert_SentenceToList()
    {
      //Arrange
      string sentence = "Rose rose to put roses";
      List<string> testList = new List<string>() {"Rose", "rose", "to", "put", "roses"};
      //Act
      RepeatConter instance = new RepeatConter();
      List<string> resultList = instance.ConvertSentenceToList(sentence);
      //Assert
      Assert.Equal(testList, resultList);
    }
    // [Fact]
    // public void CountRepeats_returns_rightNumerOfRepetitions
    // {
    //
    // }
  }
}
