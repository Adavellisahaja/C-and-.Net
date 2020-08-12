namespace Time_Tracker_Form
{
    partial class AthleteNames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        //  Windows Form Designer generated code
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AthleteNames));
            this.buttonForAddAthleteToList = new System.Windows.Forms.Button();
            this.athleteListLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.stopWatchLabel = new System.Windows.Forms.Label();
            this.timerToDisplayTime = new System.Windows.Forms.Timer(this.components);
            this.lapButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.richTextBoxForAthleteTimes = new System.Windows.Forms.RichTextBox();
            this.listBoxForAthlete = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.labelForTime = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.reportMakerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonForAddAthleteToList
            // 
            this.buttonForAddAthleteToList.Location = new System.Drawing.Point(106, 133);
            this.buttonForAddAthleteToList.Name = "buttonForAddAthleteToList";
            this.buttonForAddAthleteToList.Size = new System.Drawing.Size(118, 40);
            this.buttonForAddAthleteToList.TabIndex = 0;
            this.buttonForAddAthleteToList.Text = "Add Athlete To List";
            this.buttonForAddAthleteToList.UseVisualStyleBackColor = true;
            this.buttonForAddAthleteToList.Click += new System.EventHandler(this.buttonForAddAthleteToList_Click);
            // 
            // athleteListLabel
            // 
            this.athleteListLabel.AutoSize = true;
            this.athleteListLabel.Location = new System.Drawing.Point(513, 23);
            this.athleteListLabel.Name = "athleteListLabel";
            this.athleteListLabel.Size = new System.Drawing.Size(76, 13);
            this.athleteListLabel.TabIndex = 1;
            this.athleteListLabel.Text = "List of Athletes";
            this.athleteListLabel.Click += new System.EventHandler(this.athleteListLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(29, 55);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(29, 100);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(116, 52);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.Tag = "FirstName";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(116, 97);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.Tag = "LastName";
            // 
            // stopWatchLabel
            // 
            this.stopWatchLabel.AutoSize = true;
            this.stopWatchLabel.Location = new System.Drawing.Point(18, 227);
            this.stopWatchLabel.Name = "stopWatchLabel";
            this.stopWatchLabel.Size = new System.Drawing.Size(64, 13);
            this.stopWatchLabel.TabIndex = 7;
            this.stopWatchLabel.Text = "Stop Watch";
            this.stopWatchLabel.Click += new System.EventHandler(this.stopWatchLabel_Click);
            // 
            // timerToDisplayTime
            // 
            this.timerToDisplayTime.Interval = 1;
            this.timerToDisplayTime.Tick += new System.EventHandler(this.timerToDisplayTime_Tick);
            // 
            // lapButton
            // 
            this.lapButton.Location = new System.Drawing.Point(244, 275);
            this.lapButton.Name = "lapButton";
            this.lapButton.Size = new System.Drawing.Size(75, 23);
            this.lapButton.TabIndex = 10;
            this.lapButton.Text = "Lap";
            this.lapButton.UseVisualStyleBackColor = true;
            this.lapButton.Click += new System.EventHandler(this.Lap_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(130, 275);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.Stop_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(21, 275);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // richTextBoxForAthleteTimes
            // 
            this.richTextBoxForAthleteTimes.Location = new System.Drawing.Point(357, 192);
            this.richTextBoxForAthleteTimes.Name = "richTextBoxForAthleteTimes";
            this.richTextBoxForAthleteTimes.Size = new System.Drawing.Size(274, 148);
            this.richTextBoxForAthleteTimes.TabIndex = 13;
            this.richTextBoxForAthleteTimes.Text = "Name of the Athlete Running: ";
            this.richTextBoxForAthleteTimes.TextChanged += new System.EventHandler(this.richTextBoxForAthleteTimes_TextChanged);
            // 
            // listBoxForAthlete
            // 
            this.listBoxForAthlete.FormattingEnabled = true;
            this.listBoxForAthlete.Location = new System.Drawing.Point(451, 52);
            this.listBoxForAthlete.Name = "listBoxForAthlete";
            this.listBoxForAthlete.Size = new System.Drawing.Size(180, 121);
            this.listBoxForAthlete.TabIndex = 14;
            this.listBoxForAthlete.Tag = "ListBox";
            this.listBoxForAthlete.SelectedIndexChanged += new System.EventHandler(this.listBoxForAthlete_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(244, 222);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // labelForTime
            // 
            this.labelForTime.AutoSize = true;
            this.labelForTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForTime.Location = new System.Drawing.Point(102, 225);
            this.labelForTime.Name = "timeLabel";
            this.labelForTime.Size = new System.Drawing.Size(114, 20);
            this.labelForTime.TabIndex = 16;
            this.labelForTime.Text = "00:00:00.000";
            this.labelForTime.Click += new System.EventHandler(this.labelForTime_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 349);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(286, 76);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // reportMakerBtn
            // 
            this.reportMakerBtn.Location = new System.Drawing.Point(344, 385);
            this.reportMakerBtn.Name = "reportMakerBtn";
            this.reportMakerBtn.Size = new System.Drawing.Size(287, 40);
            this.reportMakerBtn.TabIndex = 18;
            this.reportMakerBtn.Text = "Create Report";
            this.reportMakerBtn.UseVisualStyleBackColor = true;
            this.reportMakerBtn.Click += new System.EventHandler(this.reportMakerBtn_Click);
            // 
            // AthleteNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 475);
            this.Controls.Add(this.reportMakerBtn);
            this.Controls.Add(this.richTextBoxForAthleteTimes);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelForTime);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.listBoxForAthlete);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.lapButton);
            this.Controls.Add(this.stopWatchLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.athleteListLabel);
            this.Controls.Add(this.buttonForAddAthleteToList);
            this.Name = "AthleteNames";
            this.Text = "Athlete Times";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // Form fields for Athlete Name adding to the list
        private System.Windows.Forms.Button buttonForAddAthleteToList;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label athleteListLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;

        


        // Form fields for displaying Stop watch and its funtionality
        private System.Windows.Forms.Label stopWatchLabel;
        private System.Windows.Forms.Label labelForTime;
        private System.Windows.Forms.ListBox listBoxForAthlete;
        private System.Windows.Forms.RichTextBox richTextBoxForAthleteTimes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timerToDisplayTime;
        private System.Windows.Forms.Button lapButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;



        // Form fields to generate report
        private System.Windows.Forms.Button reportMakerBtn;
    }
}

