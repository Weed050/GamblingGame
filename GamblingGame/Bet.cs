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
           return "Stawiam na " + Dog + " " +Amount + "zł.\n" +Bettor;
        }
        public int PayOut(int Winner)
        {

        }
    }
}
