namespace GamblingGame
{
    public partial class Form1 : Form
    {
        GreyHound[] GreyHoundArray = new GreyHound[4];
        Guy[] GuyArray = new Guy[3];
        int minimumBet = 5;
        public Form1()
        {
            InitializeComponent();
            minimumBetLabel.Text = "Minimalny zak�ad za" + minimumBet + "z�";


            Random MyRandomizer = new Random();

            GreyHoundArray[0] = new GreyHound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RaceTrackLenght = raceTrackPictureBox.Width - pictureBox1.Width,
                //Randomizer = MyRandomizer
            };
            GreyHoundArray[1] = new GreyHound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RaceTrackLenght = raceTrackPictureBox.Width - pictureBox2.Width,
                //Randomizer = MyRandomizer
            };
            GreyHoundArray[2] = new GreyHound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RaceTrackLenght = raceTrackPictureBox.Width - pictureBox3.Width,
                //Randomizer = MyRandomizer
            };
            GreyHoundArray[3] = new GreyHound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RaceTrackLenght = raceTrackPictureBox.Width - pictureBox4.Width,
                //Randomizer = MyRandomizer
            };

            GuyArray[0] = new Guy()
            {
                Name = "Janek",
                Cash = 50,
                MyRadioButton = RadioButton1,
                MyLabel = BetList1
            };
            GuyArray[1] = new Guy()
            {
                Name = "Bartek",
                Cash = 75,
                MyRadioButton = RadioButton2,
                MyLabel = BetList2

            };
            GuyArray[2] = new Guy()
            {
                Name = "Arek",
                Cash = 45,
                MyRadioButton = RadioButton3,
                MyLabel = BetList3

            };

            RadioButton1.Text = GuyArray[0].Name + " ma " + GuyArray[0].Cash + "z�";
            RadioButton2.Text = GuyArray[1].Name + " ma " + GuyArray[1].Cash + "z�";
            RadioButton3.Text = GuyArray[2].Name + " ma " + GuyArray[2].Cash + "z�";
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GreyHoundArray[i].Run())
                {
                    timer1.Stop();
                    //MessageBox.Show("Wygra� pies o numerze: "+i+".");
                    for (int z = 0; z < 3; z++)
                    {
                        GuyArray[z].Collect(i);
                        GuyArray[z].Cash += GuyArray[z].MyBet.PayOut(i);
                    }

                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void PlaceBetButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1 != null && ChooseDog != null)
            {
                int betAmount = (int)numericUpDown1.Value;
                int betDog = (int)ChooseDog.Value;
                for (int i = 0; i < 3; i++)
                {
                    if (GuyArray[i].MyRadioButton.Checked == true)
                    {
                        GuyArray[i].PlaceBet(betAmount,betDog);
                        GuyArray[i].MyLabel.Text = GuyArray[i].MyBet.GetDescription();
                    }

                }
            }
        }
    }
}