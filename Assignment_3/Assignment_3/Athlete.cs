using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2;

namespace Assignment_3
{
    public class Athlete
    {
        // Some required local variabls
        private string firstName; 
        private string lastName;

        // List of PreciseTime Objects to store times for a given athlete 
        private List<PreciseTime> laps;

        //Constructor
        public Athlete(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            // When ever a new athlete object is created, we are initializing an empty list for objects of type PreciseTime
            this.laps = new List<PreciseTime>(); 
        }

        // FirstName to set and get
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        // LastName to set and get
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        // List of laps to set and get
        public List<PreciseTime> Laps
        {
            get
            {
                return laps;
            }
            set
            {
                laps = value;
            }
        }

        //Method to add PreciseTime object to an athlete object's laps' list
        public void RecordTime(int hour, int minute, int second, int millisecond)
        {
            Laps.Add(new PreciseTime(hour, minute, second, millisecond));
        }

        // Method to print a lap time from the list of laps for a given index
        public string PrintTimes(Athlete athlete, int number)
        {
            string printedTime = athlete.Laps.ElementAt(number).ToString();
            return printedTime;
        }

        // Method to print entire name of athelete concatenating first name and last name
        public string PrintName(Athlete athlete)
        {
            string name = athlete.FirstName + " " + athlete.LastName;
            return name;
        }
    }
}
