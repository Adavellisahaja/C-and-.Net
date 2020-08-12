using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class PreciseTime : Time2
    {
        private int milliSecond;

        // Constructor with paramaters defaulted
        // Can be called with any number of params
        public PreciseTime(int hour = 0, int minute = 0, int second = 0, int milliSecond = 0) : base(hour, minute, second)
        {
            MilliSecond = milliSecond; // invoke SetTime to validate time
        }

        // Time2 constructor: another Time2 object supplied as an argument
        public PreciseTime(PreciseTime time) : this(time.Hour, time.Minute, time.Second, time.MilliSecond)
        {

        }

        // MilliSec field additional to the inherited Time2.cs class
        // Sets and Gets the Millisec value 
        public int MilliSecond
        {
            get
            {
                return milliSecond;
            }
            set
            {
                if (value < 0 || value > 999)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(MilliSecond)} must be within 0-999");
                }

                milliSecond = value;
            }
        }



        // Overriding ToString() method from Time2.cs to include MilliSecond
        public override string ToString() => $"{Hour:D2}:{Minute:D2}:{Second:D2}:{MilliSecond:D3}";

        // Overriding ToUniversalString() method from Time2.cs to include MilliSecond
        public override string ToUniversalString() => $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
            $"{Minute:D2}:{Second:D2}:{MilliSecond:D3} {(Hour < 12 ? "AM" : "PM")}";



        // Method to normalize if any value for a field(hour/minute/second/millisec exceeds its range)
        public void AddTime(int h, int m, int s, int mS)
        {

            // Additonal MilliSeconds and Seconds to normalize the given input milliSeconds
            int additionalMilliSeconds = 0;
            int additionalSeconds = 0;

            if (MilliSecond + mS > 999)
            {
                additionalMilliSeconds = MilliSecond + mS;
                additionalSeconds += (additionalMilliSeconds / 1000);
                MilliSecond = additionalMilliSeconds % 1000;
            }
            else
            {
                MilliSecond += mS;
            }

            // Additonal Minutes to normalize the normalized seconds
        
            int additionalMinutes = 0;
            if (Second + s > 59)
            {
                additionalSeconds += (Second + s);
                additionalMinutes += (additionalSeconds / 60);
                Second = additionalSeconds % 60;
            }
            else
            {
                Second += s;
                Second += additionalSeconds;
            }

            // Additonal Hours to normalize the normalized minutes
            int additionalHours = 0;

            if (Minute + m > 59)
            {
                additionalMinutes += (Minute + m);
                additionalHours += (additionalMinutes / 60);
                Minute = additionalMinutes % 60;
            }
            else
            {

                Minute += m;
                Minute += additionalMinutes;
            }

            if (Hour + h > 23)
            {
                additionalHours += (Hour + h);
                Hour = additionalHours % 12;
            }
            else
            {
                Hour += h;
                Hour += additionalHours;
            }
        }

        // Add time method with a PreciseTime object as parameter
        public void AddTime(PreciseTime aTime)
        {
            // Additonal MilliSeconds and Seconds to normalize the given input milliSeconds
            int additionalMilliSeconds = 0;
            int additionalSeconds = 0;

            if (MilliSecond + aTime.MilliSecond > 999)
            {
                additionalMilliSeconds = MilliSecond + aTime.MilliSecond;
                additionalSeconds += (additionalMilliSeconds / 1000);
                MilliSecond = additionalMilliSeconds % 1000;
            }
            else
            {
                MilliSecond += aTime.MilliSecond;
            }
            
            // Additonal Minutes to normalize the normalized seconds
            int additionalMinutes = 0;

            if (Second + aTime.Second > 59)
            {
                additionalSeconds += Second + aTime.Second;
                additionalMinutes += (additionalSeconds / 60);
                Second = additionalSeconds % 60;
            }
            else
            {
                Second += aTime.Second;
                Second += additionalSeconds;
            }

            // Additonal Hours to normalize the normalized minutes
            int additionalHours = 0;

            if (Minute + aTime.Minute > 59)
            {
                additionalMinutes += (Minute + aTime.Minute);
                additionalHours += (additionalMinutes / 60);
                Minute = additionalMinutes % 60;
            }
            else
            {
                Minute += aTime.Minute;
                Minute += additionalMinutes;
            }

            if (Hour + aTime.Hour > 23)
            {
                additionalHours += (Hour + aTime.Hour);
                Hour = additionalHours % 12;
            }
            else
            {
                Hour += aTime.Hour;
                Hour += additionalHours;
            }

        }
    }
}
