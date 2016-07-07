using System;
using Scrabble.Objects;
using Xunit;
using System.Collections.Generic;

namespace Scrabble
{
  public class ScrabbleTest
  {
    [Fact]
    public void ScrabbleTestForLetter_ALetter()
    {
      int pointoutput = 5;
      ScrabbleScore scrabble = new ScrabbleScore();
      int wordinput = scrabble.WordPointValue("cat");
      Assert.Equal(pointoutput, wordinput);
    }
  }
}
