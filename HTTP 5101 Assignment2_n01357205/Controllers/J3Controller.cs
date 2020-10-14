using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment2_n01357205.Controllers
{
    /// <summary>
    /// Cell-Phone Messaging J3 Problem.
    /// Returns the minimal number of seconds needed to type in the word.
    /// </summary>
    /// <param name="word">   The word to be typed in the cellphone     </param>
    /// <example>
    ///     GET api/J3/TimeNeeded/dada     ->   4
    /// </example>
    /// <example>
    ///     GET api/J3/TimeNeeded/bob      ->   7
    /// </example>
    /// <example>
    ///     GET api/J3/TimeNeeded/abba     ->   12
    /// </example>
    /// <returns>Returns an integer representing the minimal seconds taken to type in the word</returns>
    public class J3Controller : ApiController
    {   
        [HttpGet]
        [Route("api/J3/TimeNeeded/{word}")]
        public int TimeNeeded(string word)
        {
            int[] noofClicks = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 1, 2, 3, 4 };
            //                 { a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z }
            int[] parentKeys = { 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 9, 9, 9, 9 };

            int timeTaken = 0;
            char currentChar = word[0];
            char previousChar = word[0];
            timeTaken += noofClicks[currentChar - 'a'];
            for (int i = 1; i < word.Length; i++)
            {
                currentChar = word[i];
                if (parentKeys[previousChar - 'a'] == parentKeys[currentChar - 'a'])
                {
                    timeTaken += 2;
                    timeTaken += noofClicks[currentChar - 'a'];
                }
                else
                {
                    timeTaken += noofClicks[currentChar - 'a'];
                }
                previousChar = currentChar;
            }
            return timeTaken;
        }
    }
}
