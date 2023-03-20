using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingGame
{
    public class GreyHound
    {
        public int StartingPosition;
        public int RaceTrackLenght;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;
        public bool Run()
        {
            int rand = MyRandom.Next(5);
            Location += rand;
            MyPictureBox.Left += rand;
            if (RaceTrackLenght <= Location)
            {
                return true;
            }
            else 
            {
                return false;    
            }
        }
        public void TakeStartingPoint()
        {
            Location = 0;
            Location = StartingPosition;
        }
    }
}
