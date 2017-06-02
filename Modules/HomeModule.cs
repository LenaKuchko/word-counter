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
          string modifiedString = instance.RemoveSyntaxSigns(Request.Form["sentence"]);
          int repetitiveNumber = instance.CountRepeats(instance.ConvertSentenceToList(modifiedString), Request.Form["word"]);
          Dictionary <string, object> result = new Dictionary<string, object>(){};
          result.Add("sentence", Request.Form["sentence"]);
          result.Add("word", Request.Form["word"]);
          result.Add("repetitiveNumber", repetitiveNumber);
          return View ["result.cshtml", result];
        }
      };
    }
  }
}
