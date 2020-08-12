using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOne;

namespace LibraryThree
{
    public class Time2ss : Time2
    {
        private int milliseconds;

        //fully parameterized constructor
        public Time2ss(int h, int m, int s, int ms)
        {
            Hour = h;
            Minute = m;
            Second = s;
            Milliseconds = ms;
        }

        //constructor that only expects H, M, S and Defaults to 0 mSec
        public Time2ss(int h, int m, int s)
        {
            Milliseconds = 0;
        }

        //constructor that expects a time2ss object
        public Time2ss(Time2ss time)
        : this(time.Hour, time.Minute, time.Second, time.Milliseconds) { }


        public int Milliseconds
        {
            get
            {
                return milliseconds;
            }
            set
            {
                if (0 < value && value < 999)
                    milliseconds = value;
                else
                    throw new ArgumentOutOfRangeException("milliseconds ", value, "milliseconds  must be between 0 and 999 ");
            }
        }

        //overriding toUniversalString
        public new virtual string ToUniversalString() =>
            $" Time2ss {base.ToUniversalString()} {milliseconds }";

        //Overriding toString
        public override string ToString() =>
         $" Time2ss {base.ToString()} {milliseconds }";
    }
}