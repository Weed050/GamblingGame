namespace GamblingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            raceTrackPictureBox = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            RadioButton1 = new RadioButton();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            minimumBetLabel = new Label();
            RadioButton2 = new RadioButton();
            RadioButton3 = new RadioButton();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            NameLabel = new Label();
            BetList1 = new Label();
            BetList2 = new Label();
            BetList3 = new Label();
            label4 = new Label();
            ChooseDog = new NumericUpDown();
            buttonStart = new Button();
            PlaceBetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)raceTrackPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChooseDog).BeginInit();
            SuspendLayout();
            // 
            // raceTrackPictureBox
            // 
            raceTrackPictureBox.Image = (Image)resources.GetObject("raceTrackPictureBox.Image");
            raceTrackPictureBox.Location = new Point(30, 12);
            raceTrackPictureBox.Name = "raceTrackPictureBox";
            raceTrackPictureBox.Size = new Size(733, 286);
            raceTrackPictureBox.TabIndex = 1;
            raceTrackPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(30, 158);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(30, 226);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Checked = true;
            RadioButton1.Location = new Point(49, 360);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(135, 24);
            RadioButton1.TabIndex = 6;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "JoeRadioButton";
            RadioButton1.UseVisualStyleBackColor = true;
            RadioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 312);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 7;
            label1.Text = "Gambling House";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // minimumBetLabel
            // 
            minimumBetLabel.AutoSize = true;
            minimumBetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minimumBetLabel.Location = new Point(49, 337);
            minimumBetLabel.Name = "minimumBetLabel";
            minimumBetLabel.Size = new Size(138, 20);
            minimumBetLabel.TabIndex = 8;
            minimumBetLabel.Text = "minimumBetLabel";
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(49, 390);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(140, 24);
            RadioButton2.TabIndex = 9;
            RadioButton2.Text = "BobRadioButton";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Location = new Point(49, 420);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(144, 24);
            RadioButton3.TabIndex = 10;
            RadioButton3.Text = "AdinRadioButton";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(217, 337);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 11;
            label3.Text = "zakłady";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(169, 467);
            numericUpDown1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 27);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(31, 467);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(0, 20);
            NameLabel.TabIndex = 13;
            // 
            // BetList1
            // 
            BetList1.AutoSize = true;
            BetList1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BetList1.Location = new Point(217, 360);
            BetList1.Name = "BetList1";
            BetList1.Size = new Size(51, 20);
            BetList1.TabIndex = 14;
            BetList1.Text = "label2";
            // 
            // BetList2
            // 
            BetList2.AutoSize = true;
            BetList2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BetList2.Location = new Point(217, 388);
            BetList2.Name = "BetList2";
            BetList2.Size = new Size(51, 20);
            BetList2.TabIndex = 15;
            BetList2.Text = "label2";
            // 
            // BetList3
            // 
            BetList3.AutoSize = true;
            BetList3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BetList3.Location = new Point(217, 420);
            BetList3.Name = "BetList3";
            BetList3.Size = new Size(51, 20);
            BetList3.TabIndex = 16;
            BetList3.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(230, 469);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 18;
            label4.Text = "zł na charta numer ";
            // 
            // ChooseDog
            // 
            ChooseDog.Location = new Point(371, 467);
            ChooseDog.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            ChooseDog.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ChooseDog.Name = "ChooseDog";
            ChooseDog.Size = new Size(55, 27);
            ChooseDog.TabIndex = 19;
            ChooseDog.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(522, 336);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(266, 107);
            buttonStart.TabIndex = 20;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // PlaceBetButton
            // 
            PlaceBetButton.Location = new Point(88, 465);
            PlaceBetButton.Name = "PlaceBetButton";
            PlaceBetButton.Size = new Size(67, 29);
            PlaceBetButton.TabIndex = 21;
            PlaceBetButton.Text = "stawia";
            PlaceBetButton.UseVisualStyleBackColor = true;
            PlaceBetButton.Click += PlaceBetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(PlaceBetButton);
            Controls.Add(buttonStart);
            Controls.Add(ChooseDog);
            Controls.Add(label4);
            Controls.Add(BetList3);
            Controls.Add(BetList2);
            Controls.Add(BetList1);
            Controls.Add(NameLabel);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(RadioButton3);
            Controls.Add(RadioButton2);
            Controls.Add(minimumBetLabel);
            Controls.Add(label1);
            Controls.Add(RadioButton1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(raceTrackPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Dzień na wyścigach";
            ((System.ComponentModel.ISupportInitialize)raceTrackPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChooseDog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox raceTrackPictureBox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private RadioButton RadioButton1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label minimumBetLabel;
        private RadioButton RadioButton2;
        private RadioButton RadioButton3;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label NameLabel;
        private Label BetList1;
        private Label BetList2;
        private Label BetList3;
        private Label label4;
        private NumericUpDown ChooseDog;
        private Button buttonStart;
        private Button PlaceBetButton;
    }
}