using System;

namespace CarLotSimulator
{
    public class Car
    {

        public Car()
        {
           

        }


        public Car(string make, string model)
        {
            Make = make;
            Model = model;

        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"Engine noise: {EngineNoise}");

        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"Engine noise:{HonkNoise}");


        }
    }
}

