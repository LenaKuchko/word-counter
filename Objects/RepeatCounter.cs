using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatConter
  {
    public List<string> ConvertSentenceToList(string sentence)
    {
      List<string> words = sentence.ToLower().Split(' ').ToList();
      return words;
    }

    public int CountRepeats(List<string> words, string word)
    {
      word = word.ToLower();
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
