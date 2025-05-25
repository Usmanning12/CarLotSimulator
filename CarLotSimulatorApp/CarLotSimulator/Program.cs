namespace CarLotSimulator
{
    class Program 
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
             var carOne= new Car();
            carOne.Make = "Honda";
            carOne.Year = 2022;
            carOne.Model = "Civic"; 
            carOne.EngineNoise = "vroom";
            carOne.HonkNoise = "beep";
            carOne.IsDriveable = true;
            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);
            
            carLotOne.ParkingLot.Add(carOne);

            var carTwo = new Car()
            {
                Make = "Mercury",
                Model = "Club Coupe",
                Year = 2022,
                EngineNoise = "vroom vroom",
                HonkNoise = "honk", 
                IsDriveable = true
            };
            carTwo.MakeEngineNoise(carTwo.EngineNoise); 
            carTwo.MakeHonkNoise(carTwo.HonkNoise);
            carLotOne.ParkingLot.Add(carTwo);
            
            var carThree = new Car("Tesla", "CyberTruck", 2023, true);
            carThree.EngineNoise = "vroom vroom";
            carThree.HonkNoise = "beep beep";
            
            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);
            
            carLotOne.ParkingLot.Add(carThree);
            
            carLotOne.CheckCars();
            
            
            
            
            
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
            
        }   
        
    }

    
}
