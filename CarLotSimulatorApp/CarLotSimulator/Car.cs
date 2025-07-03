using System;

namespace CarLotSimulator
{
    public class Car
    {
        //TODO

        //Create a separate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        
        public string Make { get; set; }
       public  int Year { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        
        
        public  void MakeEngineNoise(string EngineNoise)
        {
            
            Console.WriteLine($"{Make} {Model} has an engine noise that sounds like {EngineNoise}");
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            
            Console.WriteLine($"{Make} {Model} has a honk noise that sounds like {HonkNoise}");
        }

        public Car()
        {
            
        }

        public Car(string make, string model, int year, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = isDriveable; 
            
            CarLot.NumberOfCars++;
        }
        
        
        

        
    }
    
     
    
}

