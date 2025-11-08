using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPractical_CarLibrary
{
    public class Car
    {
        // Private Fields
        private string make;
        private string model;
        private int year;
        private Engine engine;

        // Get/Set Constructors
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        // Constructors for Car object
        public Car()
        {
            this.Make = "Random Make";
            this.Model = "Random Model";
            this.Year = 2025;
            Engine = new Engine();
        }

        public Car(string carMake, string CarModel, int carYear, Engine carEngine)
        {
            this.Make = carMake;
            this.Model = CarModel;
            this.Year = carYear;
            this.Engine = carEngine;
        }

        // Methods
        public void Drive()
        {
            Engine.Start();
            Console.WriteLine("Driving Started");
        }

        public void Stop()
        {
            Engine.Stop();
            Console.WriteLine("Driving Stopped");
        }
    }
}