using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_3;
using Assignment_2;

namespace Time_Tracker_Form
{
    public partial class AthleteNames : Form
    {
        // List of Athlete objects
        List<Athlete> listOfAthletes = new List<Athlete>(); 

        // All local variables to pass across methods
        int milliSecondValue = 0; 
        int secondValue = 0;
        int minuteValue = 0;
        int hourValue = 0;
        int textBoxNumber = 0;
        string timeBoxTextHelper;

        public AthleteNames()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // ADDING AND MAINTAINING ATHLETES LIST LOGIC

        // Add Method
        // Logic: adds athelete object 
        private void buttonForAddAthleteToList_Click(object sender, EventArgs e)
        {

            // Creates new athlete object and adds to the list of type Athlete created above
            listOfAthletes.Add(new Athlete(firstNameTextBox.Text, lastNameTextBox.Text));
                        
            // Clear the textbox since we already added those values to list
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            
            // Clearing the box items
            listBoxForAthlete.Items.Clear();

            // We now write each item from list to the athlete list box
            foreach(Athlete a in listOfAthletes)
            {
                listBoxForAthlete.Items.Add(a.FirstName + " " + a.LastName);
            }

        }



        // STOP WATCH LOGIC
        
        //Starts the timer upon user clicking start button
        private void Start_Click(object sender, EventArgs e)
        {
            timerToDisplayTime.Start();
        }

        //Adds milliseconds, seconds, minutes, and hours whenever necessary per tick
        private void timerToDisplayTime_Tick(object sender, EventArgs e)
        {
            milliSecondValue += 10;
            if (milliSecondValue > 999)
            {
                milliSecondValue = 0;
                ++secondValue;
            }

            if (secondValue > 59)
            {
                secondValue = 0;
                ++minuteValue;
            }

            if (minuteValue > 59)
            {
                minuteValue = 0;
                ++hourValue;
            }

            if (hourValue > 23)
            {
                hourValue = 0;
            }

            labelForTime.Text = ToString(hourValue, minuteValue, secondValue, milliSecondValue);
        }


        // Functionality when a reset button is clicked
        // Stop the timer
        // Set the stop watch to all zeros   
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Stop the timer - Internally clicks the stop button
            Stop_Click(sender, e);

            // Set the stop watch to all zeros   
            milliSecondValue = 0;
            secondValue = 0;
            minuteValue = 0;
            hourValue = 0;
            labelForTime.Text = ToString(hourValue, minuteValue, secondValue, milliSecondValue);
        }

        // Functionality when a lap button is clicked
        // Just capture the time but don't stop it
        // Add the time to athlete's list of Precisetime objects
        // Add it to time box
        private void Lap_Click(object sender, EventArgs e)
        {
            // Get the text from timeLabel
            timeBoxTextHelper = labelForTime.Text;

            // Add the current time to the list of laps of the then athlete selected in athleteListBox
            listOfAthletes.ElementAt(listBoxForAthlete.SelectedIndex).RecordTime(hourValue, minuteValue, secondValue, milliSecondValue);
            
            // Add the time to the list of times
            richTextBoxForAthleteTimes.AppendText(TimeBoxString(textBoxNumber, timeBoxTextHelper) + Environment.NewLine);

            // Increase the index for the next iteration
            textBoxNumber++;
        }

        // Actual Method to stop the timer
        private void Stop_Click(object sender, EventArgs e)
        {
            // Stop the timer
            timerToDisplayTime.Stop();

            // Pull the then time after stopped
            timeBoxTextHelper = labelForTime.Text;

            // Add the current time to the list of laps of the then athlete selected in athleteListBox
            listOfAthletes.ElementAt(listBoxForAthlete.SelectedIndex).RecordTime(hourValue, minuteValue, secondValue, milliSecondValue);
            
            // Add the time to the list of times
            richTextBoxForAthleteTimes.AppendText(TimeBoxString(textBoxNumber, timeBoxTextHelper) + Environment.NewLine);

            // Increase the index for the next iteration
            textBoxNumber++;
        }


        // ToString() Utility Method
        public string ToString(int hour, int minute, int second, int milliSec)
        {
            string text = $"{hour:D2}:{minute:D2}:{second:D2}.{milliSec:D3}";
            return text;
        }

        // Method to print time with index and time format
        public string TimeBoxString(int number, string text)
        {
            string theText = number + ": " + text;
            return theText;
        }

        // To display selected athelete name in Time Box
        private void listBoxForAthlete_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNumber = 0;
            richTextBoxForAthleteTimes.Text = "Name of the Athlete Running: " + listOfAthletes.ElementAt(listBoxForAthlete.SelectedIndex).PrintName(listOfAthletes.ElementAt(listBoxForAthlete.SelectedIndex)) + Environment.NewLine;
        }

        // Functionality for the report button
        // Create another instance of AthleteLaps class which displays time objects of athletes based on selection
        private void reportMakerBtn_Click(object sender, EventArgs e)
        {
            AthleteLaps report = new AthleteLaps(listOfAthletes);
            report.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void athleteListLabel_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxForAthleteTimes_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopWatchLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelForTime_Click(object sender, EventArgs e)
        {

        }
    }
}
