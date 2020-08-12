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
    public partial class AthleteLaps : Form
    {
        //Instantiating another List object so it can point to the original list from the original form window
        List<Athlete> localListOfAthletes = new List<Athlete>();

        public AthleteLaps(List<Athlete> athletes)
        {
            InitializeComponent();
            //Makes new list point to original list
            localListOfAthletes = athletes;

            //Iterating through thee list of athletes to displays each Athlete's name
            foreach (Athlete athlete in localListOfAthletes)
            {
                listBoxForAtheleteTimes.Items.Add(athlete.FirstName + " " + athlete.LastName);
            }
        }

        // When a different athlete is selected, we need to display the times of selected Athlete
        // Helper method to achieve it
        private void listBoxForAtheleteTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxForReport.Text = localListOfAthletes.ElementAt(listBoxForAtheleteTimes.SelectedIndex).PrintName(localListOfAthletes.ElementAt(listBoxForAtheleteTimes.SelectedIndex)) + Environment.NewLine;
            for (int i = 0; i < localListOfAthletes.ElementAt(listBoxForAtheleteTimes.SelectedIndex).Laps.Count; i++)
            {
                richTextBoxForReport.AppendText("[" + i + "]: " + localListOfAthletes.ElementAt(listBoxForAtheleteTimes.SelectedIndex).PrintTimes(localListOfAthletes.ElementAt(listBoxForAtheleteTimes.SelectedIndex), i) + Environment.NewLine);
            }

        }

        private void reportTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxForAthleteNames_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
