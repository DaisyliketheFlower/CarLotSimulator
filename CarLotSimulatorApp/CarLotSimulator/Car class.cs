﻿using System;
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

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.numberOfCars++;
        }


        //properties

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string enginenoise)

        {

            Console.WriteLine($"The car engine goes {EngineNoise}");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"The car's horn goes {honkNoise}");
        }
    }






}










