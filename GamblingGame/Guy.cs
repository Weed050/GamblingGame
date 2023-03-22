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
            MyBet = null;
        }
        public bool PlaceBet(int Amount,int DogToWin)
        {
            if (Amount > Cash)
            {
                MessageBox.Show("nie ustawiono");
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
                Cash -= Amount;
                MessageBox.Show("ustawiono");

                return true;
            }

        }
        public void Collect(int winner)
        {
            MessageBox.Show("Wygrał pies o numerze "+winner+".","Prosimy dokonać wypłaty.");
            
        }
    }
}
