using System.Collections.Generic;
using System;
using Nancy;
using Scrabble.Objects;

namespace Scrabble
{
  public class HomeModule : NancyModule {

    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        ScrabbleScore scrabble = new ScrabbleScore();
        int result = scrabble.WordPointValue(Request.Form["word"]);
        return View["index.cshtml", result];
      };

    }

  }

}
