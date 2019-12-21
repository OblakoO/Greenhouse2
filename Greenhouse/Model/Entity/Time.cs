using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Time
    {
        private int _hours;
        public int Hours
        {
            get { return _hours; }
            set
            {
                if ((_hours + value) >= 24)
                    _hours = (_hours + value) % 24;
                else
                {
                    _hours = _hours + value;
                }
            }
        }
        private int _minuntes;
        public int Minutes
        {
            get { return _minuntes; }
            set
            {
                if ((_minuntes + value) >= 60)
                {
                    _minuntes = (_minuntes + value) % 60;
                    Hours = 1;
                }
                else
                {
                    _minuntes = _minuntes + value;
                }
            }
        }

        public string GetTime()
        {
            return Hours + ":" + Minutes;
        }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Time(string hours, string minutes)
        {
            Hours = Int32.Parse(hours);
            Minutes = Int32.Parse(minutes);
        }

    }
}
