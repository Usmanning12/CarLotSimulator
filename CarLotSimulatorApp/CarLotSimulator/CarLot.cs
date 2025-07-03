using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public CarLot()
    {
        CarLot.NumberOfCars++; 
    }

    public static int NumberOfCars = 1;
    public List<Car> Cars = new List<Car>(); 

    
    public List<Car> ParkingLot { get; set; } = new List<Car>();
    
    public  void CheckCars()
    {
        foreach (var car in ParkingLot)
        {
            Console.WriteLine($"{car.Year} {car.Make} {car.Model} {car.EngineNoise} {car.HonkNoise} {car.IsDriveable}");
        }
        
    }
    
    
    
}

