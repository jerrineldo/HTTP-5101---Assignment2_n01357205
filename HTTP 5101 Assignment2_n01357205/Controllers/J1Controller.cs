using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment2_n01357205.Controllers
{
    /// <summary>
    /// Returns the amount of calories of the meal chosen
    /// </summary>
    /// <param name="burger_Choice">   The choice of burger in the Burger List      </param>
    /// <param name="drink_Choice">    The choice of drink in the Drink List        </param>
    /// <param name="sideorder_Choice">The choice of sidedish in the Side dish List </param>
    /// <param name="dessert_Choice">  The choice of dessert in the dessert List    </param>
    /// <example>
    ///     GET api/J1/Menu/1/2/3/4      ->   "Your total calorie count is 691"
    /// </example>
    /// <example>
    ///     GET api/J1/Menu/4/4/4/4      ->   "Your total calorie count is 0"
    /// </example>
    /// <returns>A string mentioning the amount of calories associatred with the selected meal</returns>
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger_Choice}/{drink_Choice}/{sideorder_Choice}/{dessert_Choice}")]
        public string Menu(int burger_Choice, int drink_Choice, int sideorder_Choice, int dessert_Choice)
        {
            int[] burger_Options    =  { 461, 431, 420, 0 };
            int[] drink_Options     =  { 130, 160, 118, 0 };
            int[] sideorder_Options =  { 100, 57,  70,  0 };
            int[] dessert_Options   =  { 167, 266, 75,  0 };
            int total_Calorie = 0;
            if (burger_Choice >= 1 && burger_Choice <= 4 && drink_Choice >= 1 && drink_Choice <= 4
                && sideorder_Choice >= 1 && sideorder_Choice <= 4
                && dessert_Choice >= 1 && dessert_Choice <= 4)
            {
                total_Calorie = burger_Options[burger_Choice - 1]
                                + drink_Options[drink_Choice - 1]
                                + sideorder_Options[sideorder_Choice - 1]
                                + dessert_Options[dessert_Choice - 1];
                return "Your total calorie count is " + total_Calorie;
            }
            else
            {
                return "Invalid Input given";
            }
        }
    }
}
