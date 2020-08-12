using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTwoArray
{
    public class Time2
    {
        private char[] timeArray;
        private int pointer;


        // constructor can be called with zero, one, two or three arguments
        public Time2(int h = 0, int m = 0, int s = 0)
        {
            pointer = 0;
            timeArray = new char[6];
            SetTime(h, m, s); // invoke SetTime to validate time
                              // check();
        } // end Time2 three-argument constructor


        // Time2 constructor: another Time2 object supplied as an argument
        public Time2(Time2 time)
        {
            this.timeArray = time.timeArray;
        }



        // set a new time value using universal time; ensure that
        // the data remains consistent by setting invalid values to zero
        public void SetTime(int h, int m, int s)
        {
            pointer = 0;
            Hour = h; // set the Hour property
            Minute = m; // set the Minute property
            Second = s; // set the Second property
        } // end method SetTime




        // property that gets and sets the hour
        public int Hour
        {
            get
            {
                return Int32.Parse((String.Concat(Char.ToString(timeArray[0]), Char.ToString(timeArray[1]))));
            }
            set
            {
                if (value >= 0 && value < 24)
                {
                    char[] hourArray = value.ToString().ToCharArray();


                    if (hourArray.Length == 1)
                    {
                        timeArray[pointer] = '0';
                        pointer++;
                    }


                    foreach (char ch in hourArray)
                    {

                        timeArray[pointer] = (char)0;

                        timeArray[pointer] = ch;

                        pointer++;
                    }

                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                    "Hour", value, "Hour must be 0-23");
                }
            } // end set
        } // end property Hour




        // property that gets and sets the minute
        public int Minute
        {
            get
            {

                return Int32.Parse((String.Concat(Char.ToString(timeArray[2]), Char.ToString(timeArray[3]))));

            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    char[] minuteArray = value.ToString().ToCharArray();

                    if (minuteArray.Length == 1)
                    {
                        timeArray[pointer] = '0';
                        pointer++; // 1
                    }
                    foreach (char ch in minuteArray)
                    {
                        timeArray[pointer] = ch;

                        pointer++;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                    "Minute", value, "Minute must be 0-59");
                }

            } // end set
        } // end property Minute





        // property that gets and sets the second
        public int Second
        {
            get
            {
                return Int32.Parse((String.Concat(Char.ToString(timeArray[4]), Char.ToString(timeArray[5]))));
            } // end get
            set
            {
                if (value >= 0 && value < 60)
                {
                    char[] secondArray = value.ToString().ToCharArray();

                    if (secondArray.Length == 1)
                    {
                        timeArray[pointer] = '0';
                        pointer++; // 1s
                    }
                    foreach (char ch in secondArray)
                    {
                        // timeArray[pointer] = (char)(timeArray[pointer].GetNumericValue() + ch.GetNumericValue());
                        timeArray[pointer] = ch;
                        pointer++;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                    "Second", value, "Second must be 0-59");
                }
            } // end set
        } // end property Second





        // convert to string in standard-time format (H:MM:SS AM or PM)
        public override string ToString()
        {
            String time = ToUniversalString();
            DateTime dateTime = Convert.ToDateTime(time);
            Console.WriteLine("\n*************************************************************");
            Console.WriteLine("\nThis is from new implementation using Library Two Array");
            Console.WriteLine("\n*************************************************************");

            return dateTime.ToString("h:mm:ss tt");
        }



        // convert to char[] in universal-time format (HH:MM:SS)
        public string ToUniversalString()
        {
            string rawTime = new string(timeArray);
            for (int i = 2; i < rawTime.Length; i += 2)
            {
                rawTime = rawTime.Insert(i, ":");
                i++;
            }
            return rawTime;
        }



        //Part A-->(c)
        //What should your classes do when adding time takes the time over the 23:59;59 max time in a day?

        private void check(int hour, int minute, int second)
        {
            if (second >= 60)
            {
                minute = minute + (second / 60);
                second = second % 60;
            }

            if (minute >= 60)
            {
                hour = hour + (minute / 60);
                minute = minute % 60;
            }

            if (hour >= 24)
            {
                hour = hour % 24;
            }

            Hour = hour;
            Minute = minute;
            Second = second;
        }




        //     //Part A-->(b)-->(i)
        //     // one method will add a value of time received as three integers representing number of hours, minutes and seconds to be added.
        //     // public void addtime(int h, int m, int s) { ... }
        public void addtime(int h = 0, int m = 0, int s = 0)
        {
            if (h >= 0 && m >= 0 && s >= 0)
            {

                int oldHour = Int32.Parse((String.Concat(Char.ToString(timeArray[0]), Char.ToString(timeArray[1]))));
                int oldMinute = Int32.Parse((String.Concat(Char.ToString(timeArray[2]), Char.ToString(timeArray[3]))));
                int oldSecond = Int32.Parse((String.Concat(Char.ToString(timeArray[4]), Char.ToString(timeArray[5]))));

                int newHour = oldHour + h;
                int newMinute = oldMinute + m;
                int newSecond = oldSecond + s;

                pointer = 0;

                check(newHour, newMinute, newSecond);
            }
            else
            {
                throw new ArgumentOutOfRangeException("hour,minute,seconds must be positive");
            }
        }



        // Add time using object
        public void addtime(Time2 oldTimeObject)
        {
            int oldHour = Int32.Parse((String.Concat(Char.ToString(timeArray[0]), Char.ToString(timeArray[1]))));
            int oldMinute = Int32.Parse((String.Concat(Char.ToString(timeArray[2]), Char.ToString(timeArray[3]))));
            int oldSecond = Int32.Parse((String.Concat(Char.ToString(timeArray[4]), Char.ToString(timeArray[5]))));

            int newHour = Int32.Parse((String.Concat(Char.ToString(oldTimeObject.timeArray[0]), Char.ToString(oldTimeObject.timeArray[1]))));
            int newMinute = Int32.Parse((String.Concat(Char.ToString(oldTimeObject.timeArray[2]), Char.ToString(oldTimeObject.timeArray[3]))));
            int newSecond = Int32.Parse((String.Concat(Char.ToString(oldTimeObject.timeArray[4]), Char.ToString(oldTimeObject.timeArray[5]))));

            int sumHour = oldHour + newHour;
            int sumMinute = oldMinute + newMinute;
            int sumSecond = oldSecond + newSecond;

            check(sumHour, sumMinute, sumSecond);
        }
    }
}
