using Nancy;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["home_page.cshtml"];
      Post["/result"] = _ => {
        RepeatConter instance = new RepeatConter();
        if (Request.Form["sentence"] == "")
        {
          return View ["error.cshtml"];
        }
        else
        {
          int repetitiveNumber = instance.CountRepeats(instance.ConvertSentenceToList(Request.Form["sentence"]), Request.Form["word"]);
          string result = "Sentence: " + Request.Form["sentence"] + " contains word " + Request.Form["word"] + " "  + repetitiveNumber + " times.";
          return View ["result.cshtml", result];
        }
      };
    }
  }
}
