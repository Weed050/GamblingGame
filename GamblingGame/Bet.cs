using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GamblingGame
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        public string GetDescription()
        {
            if (Amount > Bettor.Cash)
            {
                return "Nie ustanowiono układu";
            }
            else
            {
                int stringDog = Dog + 1;
                return Bettor.Name + " stawia " + Amount + "zł na psa o numerze " + stringDog + ".";
            }
        }
        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return Amount;
            }
            else
            {
               return -Amount;
            }
        }
    }
}
