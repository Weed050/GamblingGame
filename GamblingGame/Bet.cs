using System;
using System.Collections.Generic;
using System.Linq;
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
            if (Amount <= 0) return "Nie ustanowiono układu";
            else
            {
                return "Stawiam na " + Dog + " " + Amount + "zł.\n" + Bettor.Name;
            }
        }
        public int PayOut(int Winner)
        {

        }
    }
}
