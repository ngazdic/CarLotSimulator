using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car--- DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var car1 = new Car();
            var car2 = new Car();
            var car3 = new Car();

            var thisIsCarLot = new CarLot();


            car1.Year = 1998;
            car1.Make = "Subaru";
            car1.Model = "Outback";
            car1.EngineNoise = "loud";
            car1.HonkNoise = "honk";
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            car1.IsDriveable = true;

            car2.Year = 2020;
            car2.Make = "Subaru";
            car2.Model = "Outback";
            car2.EngineNoise = "loud";
            car2.HonkNoise = "honk";
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            car2.IsDriveable = true;


            car3.Year = 1998;
            car3.Make = "Mitsubishi";
            car3.Model = "Mirage";
            car3.EngineNoise = "loud";
            car3.HonkNoise = "honk";
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
            car3.IsDriveable = true;


            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var car4 = new Car()
            {

                Model = "renalut",
                Year = 1998,
                Make = "renalut 4",
                EngineNoise = "loud",
                HonkNoise = "honk",
                IsDriveable = true,

            };

            var car5 = new Car( "Mercedes","gclass" );







            //*************BONUS X 2*************//
            //var thisIsCarLot = new CarLot();


            thisIsCarLot.ListOfCars.Add(car1);
            thisIsCarLot.ListOfCars.Add(car2);
            thisIsCarLot.ListOfCars.Add(car3);


            foreach (var item in thisIsCarLot.ListOfCars)
            {
                Console.WriteLine(item.Year);
            }







            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
