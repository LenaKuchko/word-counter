using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatConter
  {
    // private int _counter;

    // public int GetCounter()
    // {
    //   return _counter;
    // }
    public List<string> ConvertSentenceToList(string sentence)
    {
      List<string> words = sentence.Split(' ').ToList();
      return words;
    }

    public int CountRepeats(List<string> words, string word)
    {
      int counter = 0;
      for (int i = 0; i < words.Count; i++)
      {
          if (words[i] == word)
          {
            counter++;
          }
      }
      return counter;
    }
  }
}
