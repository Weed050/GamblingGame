using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GamblingGame
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name+" ma "+Cash+"zł.";
        }
        public void ClearBet()
        {
            MyBet = new Bet()
            {
                Amount = 0,
                Dog = 0,
                Bettor = this
            }; ;
        }
        public bool PlaceBet(int Amount,int DogToWin)
        {
            if (Amount > Cash)
            {
                return false;

            } 
            else 
            {
                MyBet = new Bet()
                {
                    Amount = Amount,
                    Dog = DogToWin,
                    Bettor = this
                };
                //Cash -= Amount;
                return true;
            }

        }
        public void Collect(int winner)
        {
            winner += 1;
            MessageBox.Show("Wygrał pies o numerze "+winner+".","Prosimy dokonać wypłaty.");
            
        }
    }
}
