using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable )
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDriveable;

            CarLot.numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine("Vroom.");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine("Beep beep.");
        }

        public void MyCar()
        {
            Console.WriteLine($"My car is a {Year} {Model} {Make}. It is {IsDrivable} that it can drive and it likes to go:");
            
        }

        public void MyCar2()
        {
            Console.WriteLine($"My car is a {Year} {Model} {Make}. It is {IsDrivable} that it can drive and it likes to go:\n{EngineNoise}.\n{HonkNoise}.");
        }
    }

    
}
