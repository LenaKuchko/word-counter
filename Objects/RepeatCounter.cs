using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatConter
  {
    public string RemoveSyntaxSigns(string sentence)
    {
      sentence = sentence.Replace(",", "").Replace("!", "").Replace("?", "").Replace("@", "").
                          Replace("-", "").Replace(":", "").Replace(";", "");
      return sentence;
    }

    public List<string> ConvertSentenceToList(string modifiedSentence)
    {
      List<string> words = modifiedSentence.ToLower().Split(' ').ToList();
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
