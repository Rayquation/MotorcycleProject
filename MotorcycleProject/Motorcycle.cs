using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleProject
{
    internal class Motorcycle
    {
        private bool _started;
        private int _rpm;
        private int _gear;
        private string _name;

        public Motorcycle()
        {
            _rpm = 0;
            _gear = 0;
            _name = "";
            _started = false;
        }
        public Motorcycle(string name,bool started)
        {
            Name = name;
            setRpm();
            _started = started;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void setRpm()
        {
            if (isStarted() == false)
            {
                _rpm = 0;
            }else
            {
                _rpm += 1000;
            }
        }
        public int getRpm()
        {
            return _rpm;
        }
        public bool isStarted()
        {
            return _started;
        }
        public void start()
        {
            _started=true;
            setRpm();
            shiftGearDown(0);
        }
        public void shiftGearDown(int g)
        {
            _gear = g;
        }
        public void shiftGearUp()
        {
            if (_gear < 5&& isStarted()==true)
            {
                _gear++;
                setRpm();
            }
            else
            {
            }
        }
        public int getGear()
        {
            return _gear;
        }
        public int getSpeed()
        {
            return getRpm() * getGear() / 200;
        }
        public void stop()
        {
            _started = false;
            setRpm();
            shiftGearDown(0);
        }
        public override string ToString()
        {
            return ($"{Name} Gear:{getGear()} Rpm:{getRpm()} Speed:{getSpeed()} Running:{isStarted()}");
        }
    }
}
