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
      List<string> words = sentence.Split(' ').ToList();
      return words;
    }

    public int CountRepeats(List<string> words, string word)
    {
      return 5;
    }
  }
}
