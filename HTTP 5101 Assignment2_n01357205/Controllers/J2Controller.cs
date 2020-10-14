using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment2_n01357205.Controllers
{
    /// <summary>
    /// Returns the number of ways someone can roll the 2 dices to get the sum of 10.
    /// </summary>
    /// <param name="numberofsides_firstdie">   The number of sides in the first dice      </param>
    /// <param name="numberofsides_seconddie">  The number of sides in the second dice     </param>
    /// <example>
    ///     GET api/J2/DiceGame/6/8     ->   "There are 5 total ways to get the sum 10."
    /// </example>
    /// <example>
    ///     GET api/J2/DiceGame/12/4    ->   "There are 4 ways to get the sum 10"
    /// </example>
    /// <returns>A string mentioning the total number of ways the dice can be rolled to get a sum of 10</returns>
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{numberofsides_firstdie}/{numberofsides_seconddie}")]
        public string DiceGame(int numberofsides_firstdie, int numberofsides_seconddie)
        {
            int total = 10;
            int counter = 0;
            if(numberofsides_firstdie>=0 && numberofsides_seconddie >= 0)
            {
                for (int i = 1; i <= numberofsides_firstdie; i++)
                {
                    for (int j = 1; j <= numberofsides_seconddie; j++)
                    {
                        if (i + j == total)
                            counter++;
                    }
                }
                return "There are " + counter + " total ways to get the sum 10.";
            }
            else
            {
                return "Invalid input given";
            }
        }
    }
}
