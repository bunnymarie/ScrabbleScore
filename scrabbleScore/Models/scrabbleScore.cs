using System.Collections.Generic;
using System.Linq;

namespace scrabbleScore
{
  public class translatingScore
  {
    public static bool returnTest(string userInput)
    {
      char[] userArray = userInput.ToCharArray();
      List<int> userscoreArray = new List<int>();

      for(int i = 0; i < userInput.Length; i++)
      {
        if (userArray[i] == 'a' || userArray[i] == 'e' || userArray[i] == 'i' || userArray[i] == 'o' || userArray[i] == 'u' || userArray[i] == 'l' || userArray[i] == 'n' || userArray[i] == 'r' || userArray[i] == 's' || userArray[i] == 't')
        {
          userscoreArray.Add(1);
        }
        else if (userArray[i] == 'd' || userArray[i] == 'g')
        {
          userscoreArray.Add(2);
        }
        else if (userArray[i] == 'b' || userArray[i] == 'c' || userArray[i] == 'm' || userArray[i] == 'p')
        {
          userscoreArray.Add(3);
        }
        else if (userArray[i] == 'f' || userArray[i] == 'h' || userArray[i] == 'v' || userArray[i] == 'w' || userArray[i] == 'y')
        {
          userscoreArray.Add(4);
        }
        else if (userArray[i] == 'k')
        {
          userscoreArray.Add(5);
        }
        else if (userArray[i] == 'j' || userArray[i] == 'x')
        {
          userscoreArray.Add(8);
        }
        else if (userArray[i] == 'q' || userArray[i] == 'z')
        {
          userscoreArray.Add(10);
        }
        else
        {
          userscoreArray.Add(0);
        }
      }

      int userResult = userscoreArray.Sum();

      if (userResult == 29){
        return true;
      }
      else{
        return false;
      }

    }
  }
}
