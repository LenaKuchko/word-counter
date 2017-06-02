using Nancy;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : Nancy
  {
    public HomeModule()
    {
      Get ["/home_page"] = _ => View ["home_page.cshtml"];  
    }
  }
}
