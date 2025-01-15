using System.Security.Cryptography;

namespace Assignment_Session_4.Classes
{
    internal class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Methods
        //Override All System.Object Members[To String(), Equals(), GetHashCode()] .

        //override in Tostring() Method

        public override string ToString()
        {
            return $"Duration = Hours:{Hours}, Minutes:{Minutes}, Seconds:{Seconds}";
        }

        //override in Equals() Method
        public override bool Equals(object? obj)
        {
            if (obj is not null)
                if (obj is Duration other)
                {
                    return Hours == other.Hours &&
                           Minutes == other.Minutes &&
                           Seconds == other.Seconds;
                }
            return false;
        }
        //override in GetHashCode() Method
        public override int GetHashCode()
        {
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }

        #endregion 

        #region Constructors

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600; // divided by 3600 To get Hours
            Minutes = (totalSeconds % 3600) / 60; // Remaining seconds divided by 60 to get Minutes
            Seconds = totalSeconds % 60; // Remaining seconds to get Seconds
        }
        #endregion

        #region Opertaor Overloading

        // Overloading the '+' operator 
        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.Seconds + d2.Seconds;

            int totalMinutes = d1.Minutes + d2.Minutes + totalSeconds / 60;
            totalSeconds %= 60;

            int totalHours = d1.Hours + d2.Hours + totalMinutes / 60;
            totalMinutes %= 60;

            return new Duration(totalHours, totalMinutes, totalSeconds);
        }

        // Overloading the '+' operator with totalseconds

        public static Duration operator +(Duration d, int totalSeconds)
        {
            int newTotalSeconds = (d.Hours * 3600) + (d.Minutes * 60) + d.Seconds + totalSeconds;

            return new Duration(newTotalSeconds);
        }
        public static Duration operator +(int totalSeconds, Duration d)
        {
            return d + totalSeconds;
        }



        // Overloading the '++' operator 

        public static Duration operator ++(Duration D)
        {
            int totalMinutes = D.Minutes + 1;
            int totalHours = D.Hours;
            int totalSeconds = D.Seconds;

            if (totalMinutes >= 60)
            {
                totalHours += 1;
                totalMinutes %= 60; 
            }

            return new Duration(totalHours, totalMinutes, totalSeconds);
        }

        // Overloading the '--' operator 

        public static Duration operator --(Duration D)
        {
            int totalMinutes = D.Minutes - 1;
            int totalHours = D.Hours;
            int totalSeconds = D.Seconds;

            if (totalMinutes >= 60)
            {
                totalHours -= 1;
                totalMinutes %= 60;
            }

            return new Duration(totalHours, totalMinutes, totalSeconds);
        }

        // Overloading the '-' operator 

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = d1.Seconds - d2.Seconds;

            if (totalSeconds < 0)
            {
                totalSeconds += 60;
                d1.Minutes -= 1;  
            }

            int totalMinutes = d1.Minutes - d2.Minutes;

            if (totalMinutes < 0)
            {
                totalMinutes += 60;
                d1.Hours -= 1;  
            }

            int totalHours = d1.Hours - d2.Hours;

            if (totalHours < 0)
            {
                return new Duration(0);
            }

            return new Duration(totalHours, totalMinutes, totalSeconds);
        }


        // Overloading the '>' operator 
        public static bool operator >(Duration d1, Duration d2)
        {
            // Compare hours 
            if (d1.Hours > d2.Hours)
                return true;
            if (d1.Hours < d2.Hours)
                return false;

            // If hours are equal, compare minutes
            if (d1.Minutes > d2.Minutes)
                return true;
            if (d1.Minutes < d2.Minutes)
                return false;

            // If minutes are also equal, compare seconds
            return d1.Seconds > d2.Seconds;
        }

        // Overloading the '<' operator 
        public static bool operator <(Duration d1, Duration d2)
        {
            // Compare hours first
            if (d1.Hours < d2.Hours)
                return true;
            if (d1.Hours > d2.Hours)
                return false;

            // If hours are equal, compare minutes
            if (d1.Minutes < d2.Minutes)
                return true;
            if (d1.Minutes > d2.Minutes)
                return false;

            // If minutes are also equal, compare seconds
            return d1.Seconds < d2.Seconds;
        }



        // Overloading the '>=' operator 
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1 > d2 || d1 == d2;
        }


        // Overloading the '=<' operator 
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1 < d2 || d1 == d2;
        }




        #endregion

        #region Casting Operator Overloading


        //Implicit Casting Operator Overloding to convert Duration to bool
        public static implicit operator bool(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }



        // Explicit Casting operator ovetloading to convert Duration to DateTime
        public static explicit operator DateTime(Duration d)
        {
            int totalSeconds = d.Hours * 3600 + d.Minutes * 60 + d.Seconds;

            return DateTime.MinValue.AddSeconds(totalSeconds);
        }
        #endregion

    }
}
