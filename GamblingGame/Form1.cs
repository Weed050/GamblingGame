using System.Security.Cryptography.X509Certificates;

namespace GamblingGame
{
    public partial class Form1 : Form
    {
        GreyHound[] GreyHoundArray = new GreyHound[4];
        Guy[] GuyArray = new Guy[3];
        int minimumBet = 5;
        public void DisplayOnLabel()
        {
            RadioButton1.Text = GuyArray[0].Name + " ma " + GuyArray[0].Cash + "z³";
            RadioButton2.Text = GuyArray[1].Name + " ma " + GuyArray[1].Cash + "z³";
            RadioButton3.Text = GuyArray[2].Name + " ma " + GuyArray[2].Cash + "z³";
            NameLabel.Text = GuyArray[0].Name;
        }
        public Form1()
        {
            InitializeComponent();
            minimumBetLabel.Text = "Minimalny zak³ad za" + minimumBet + "z³";



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

            DisplayOnLabel();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GreyHoundArray[i].Run())
                {
                    timer1.Stop();
                    //MessageBox.Show("Wygra³ pies o numerze: "+i+".");
                    for (int z = 0; z < 3; z++)
                    {
                        NameLabel.Text = GuyArray[0].Name;
                        GuyArray[z].Collect(i);
                        if (GuyArray[z].MyBet != null)
                        {
                            GuyArray[z].Cash += GuyArray[z].MyBet.PayOut(i);
                        }
                        else
                        {
                            MessageBox.Show("Nie postawiono zak³adów");
                        }
                        DisplayOnLabel();
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
                int betDog = (int)ChooseDog.Value -1;
                for (int i = 0; i < 3; i++)
                {
                    if (GuyArray[i].MyRadioButton.Checked == true)
                    {
                        //GuyArray[i].PlaceBet(betAmount, betDog);

                        //GuyArray[i].MyLabel.Text = GuyArray[i].MyBet.GetDescription();

                        if (GuyArray[i].PlaceBet(betAmount, betDog))
                        {
                            GuyArray[i].MyLabel.Text = GuyArray[i].MyBet.GetDescription();
                        }
                        else
                        {
                            GuyArray[i].MyLabel.Text = "Nie ustanowiono uk³adu";
                        }
                    }

                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}