namespace GamblingGame
{
    public partial class Form1 : Form
    {
        GreyHound[] GreyHoundArray = new GreyHound[4];
        public Form1()
        {
            InitializeComponent();
           
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

            //Guy[] GuyArray = new Guy[3];
            //GuyArray[0] = new Guy()
            //{

            //};
            //GuyArray[1] = new Guy()
            //{

            //};
            //GuyArray[2] = new Guy()
            //{

            //};
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GreyHoundArray[i].Run())
                {
                   timer1.Stop();
                    MessageBox.Show("Wygra³ pies o numerze: "+i+".");
                }
            }

        }
    }
}