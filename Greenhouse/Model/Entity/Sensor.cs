using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Sensor: IDevice
    {
        private ITimer _timer;
        public Location Location { get; set; }
        public Sensor( ITimer timer)
        {
            
            _timer = timer;
            _timer.Interval = 1000;
            _timer.Tick += TimerTick;
            _timer.Start();

        }

        private void TimerTick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
