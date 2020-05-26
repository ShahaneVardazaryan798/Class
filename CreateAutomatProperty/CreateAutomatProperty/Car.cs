using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CreateAutomatProperty
{
    class Car
    {
        private string Name { set; get; } = "Lada";
        private int maxSpeed { set; get; }
        private int currentSpeed;
        private double power; 
        public int CurrentSpeed
        { 
            get => currentSpeed; 
            set
            {
                if(currentSpeed>=0 && currentSpeed<=maxSpeed)
                {
                    currentSpeed = value;
                }
            }
        }
        public double Power 
        { 
            get => power; 
            set
            {
                if(power>0)
                {
                    power = value;
                }
            }
        }
        public Car()
        {
           //WriteLine("Def Ctor");
        }

        public Car(string nm="bmv",int msp=300,int csp=80,double pow=1.4)
        {
            //WriteLine("The ctor of four params");
            Name = nm;
            maxSpeed =msp;
            CurrentSpeed = csp;
            Power = pow;

        }
        
    }
}
