namespace GamblingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GreyHound[] GreyHoundArray = new GreyHound[4];
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
        }
    }
}