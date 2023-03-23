using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
	public class CarLot
	{
		public CarLot()
		{
		}

		public static int numberOfCars;


		public List<Car> ParkingLot { get; set; } = new List<Car>();
	}


}

