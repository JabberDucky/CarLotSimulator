using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var carlot = new CarLot();

            var car1 = new Car();
            car1.Year = 2024;
            car1.Make = "Tesla";
            car1.Model = "Model S";
            car1.IsDrivable = true;

            car1.MyCar();
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            carlot.ListOfCars.Add(car1);

            var car2 = new Car()
            {
                Year = 2023,
                Make = "Subaru",
                Model = "Outback",
                IsDrivable = true,
            };

            car2.MyCar();
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            carlot.ListOfCars.Add(car2);

            var car3 = new Car(2006, "R Corvette", "C6", "Vroom", "Beep beep.", true);

            car3.MyCar2();

            carlot.ListOfCars.Add(car3);

            foreach(var car in carlot.ListOfCars)
            {
                Console.WriteLine($"This is a {car.Make} {car.Model} {car.Year}");
            }
        }
    }
}
