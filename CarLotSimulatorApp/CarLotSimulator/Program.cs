using System;
using System.Reflection;

namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
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


            var daisysCarLot = new CarLot();


            var Toyota = new Car();


            Toyota.Year = 2022;
            Toyota.Make = "Toyota";
            Toyota.Model = "Camry";
            Toyota.EngineNoise = "vroom";
            Toyota.HonkNoise = "beep";
            Toyota.IsDriveable = true;

            daisysCarLot.ParkingLot.Add(Toyota);


            var Ford = new Car()
            {

                Year = 2018,
                Make = "Ford",
                Model = "Fusion",
                EngineNoise = "rumble",
                HonkNoise = "honk",
                IsDriveable = true

            };

            daisysCarLot.ParkingLot.Add(Ford);

            var tesla = new Car(2021, "Tesla", "Wrangler Unlimited", "whir", "beep beep", true );

        daisysCarLot.ParkingLot.Add(tesla);
            Console.WriteLine($"Number of Cars{CarLot.numberOfCars}");


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in daisysCarLot.ParkingLot)
            {

                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make:{car.Make}");
                Console.WriteLine($"Model:{car.Model}");
            

                 car.MakeEngineNoise(car.EngineNoise);
                  car.MakeHonkNoise(car.HonkNoise);

                  Console.WriteLine();
            
            }
        }

    }

}