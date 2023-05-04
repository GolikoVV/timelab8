using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timelab8
{
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public static Time operator +(Time t1, Time t2)
        {
            int totalSeconds = t1.GetTotalSeconds() + t2.GetTotalSeconds();
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return new Time(hours, minutes, seconds);
        }

        public static Time operator -(Time t1, Time t2)
        {
            int totalSeconds = t1.GetTotalSeconds() - t2.GetTotalSeconds();
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return new Time(hours, minutes, seconds);
        }

        public static bool operator >(Time t1, Time t2)
        {
            return t1.GetTotalSeconds() > t2.GetTotalSeconds();
        }

        public static bool operator <(Time t1, Time t2)
        {
            return t1.GetTotalSeconds() < t2.GetTotalSeconds();
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return t1.GetTotalSeconds() >= t2.GetTotalSeconds();
        }

        public static bool operator <=(Time t1, Time t2)
        {
            return t1.GetTotalSeconds() <= t2.GetTotalSeconds();
        }

        public static bool operator ==(Time t1, Time t2)
        {
            return t1.GetTotalSeconds() == t2.GetTotalSeconds();
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return t1.GetTotalSeconds() != t2.GetTotalSeconds();
        }

        public void Increment()
        {
            seconds++;
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
                if (minutes >= 60)
                {
                    minutes = 0;
                    hours++;
                    if (hours >= 24)
                    {
                        hours = 0;
                    }
                }
            }
        }

        public void Decrement()
        {
            seconds--;
            if (seconds < 0)
            {
                seconds = 59;
                minutes--;
                if (minutes < 0)
                {
                    minutes = 59;
                    hours--;
                    if (hours < 0)
                    {
                        hours = 23;
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"{hours:00}:{minutes:00}:{seconds:00}";
        }

        private int GetTotalSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }
    }
}