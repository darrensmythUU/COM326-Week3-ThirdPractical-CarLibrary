using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPractical_CarLibrary
{
    public class Engine
    {
        // Private Fields
        private int cylinders;
        private double horsepower;

        // Get/Set Constructors
        public int Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }

        public double Horsepower
        {
            get { return horsepower; }
            set { horsepower = value; }
        }

        // Constructors for Engine object
        public Engine()
        {
            this.Cylinders = 0;
            this.Horsepower = 0;
        }

        public Engine(int engineCylinders, int engineHorsepower)
        {
            this.Cylinders = engineCylinders;
            this.Horsepower = engineHorsepower;
        }

        // Methods
        public void Start()
        {
            Console.WriteLine("Engine Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Engine Stopping");
        }
    }
}