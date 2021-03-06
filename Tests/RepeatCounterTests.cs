using System;
using System.Collections.Generic;
using Xunit;
using WordCounter;

namespace WordCounter
{
  public class WordCounterTests
  {
    [Fact]
    public void ClearString_removeSyntaxSigns()
    {
      //Arrange
      string sentence = "Rose rose to put roses";
      //Act
      RepeatConter instance = new RepeatConter();
      string result = instance.RemoveSyntaxSigns("Rose? rose: to put, roses!");
      //Assert
      Assert.Equal(sentence, result);
    }
    [Fact]
    public void Convert_SentenceToList()
    {
      //Arrange
      string sentence = "Rose rose to put roses";
      List<string> testList = new List<string>() {"rose", "rose", "to", "put", "roses"};
      //Act
      RepeatConter instance = new RepeatConter();
      List<string> resultList = instance.ConvertSentenceToList(sentence);
      //Assert
      Assert.Equal(testList, resultList);
    }
    [Fact]
    public void CountRepeats_CaseInsensitive()
    {
      //Arrange
      List<string> testList = new List<string>() {"Rose", "rose", "to", "put", "rose", "roses", "rose"};
      //Act
      RepeatConter instance = new RepeatConter();
      int result = instance.CountRepeats(testList, "rose");
      //Assert
      Assert.Equal(3, result);
      Console.WriteLine("CountRepeats_CaseInsensitive " + result);
    }
    [Fact]
    public void SentenceDoesntContainWord()
    {
      //Arrange
      List<string> testList = new List<string>() {"Rose", "rose", "to", "put", "rose", "roses", "rose"};
      //Act
      RepeatConter instance = new RepeatConter();
      int result = instance.CountRepeats(testList, "tulip");
      //Assert
      Assert.Equal(0, result);
      Console.WriteLine("SentenceDoesntContainWord " + result);
    }
    [Fact]
    public void EmptyInput()
    {
      //Arrange
      List<string> testList = new List<string>() {};
      //Act
      RepeatConter instance = new RepeatConter();
      int result = instance.CountRepeats(testList, "rose");
      //Assert
      Assert.Equal(0, result);
      Console.WriteLine("SentenceDoesntContainWord " + result);
    }
    [Fact]
    public void CountRepeats_CaseSensitive()
    {
      //Arrange
      string testSentence = "RoSe rosE TO pUt RosE roses";
      //Act
      RepeatConter instance = new RepeatConter();
      int result = instance.CountRepeats(instance.ConvertSentenceToList(testSentence), "rose");
      //Assert
      Assert.Equal(3, result);
      Console.WriteLine("CountRepeats_CaseSensitive " + result);
    }
  }
}
