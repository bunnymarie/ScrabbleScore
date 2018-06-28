using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using scrabbleScore;


namespace scrabbleScore.Tests
{
  [TestClass]
  public class translatingScoreTest
  {
    [TestMethod]
    public void IstranslatingScore_NumberEqualsSixteen_True()
    {
      Assert.AreEqual(true, translatingScore.returnTest("quacksalver"));
    }
  }
}
