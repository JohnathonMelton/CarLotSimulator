using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();

            Car tundra = new Car();
            lot.CarList.Add(tundra);

            tundra.Year = 2022;
            tundra.Make = "Toyota";
            tundra.Model = "Tundra";
            tundra.EngineNoise = "The Tundra has a satisfying engine sound if you like trucks.";
            tundra.HonkNoise = "The honk on the Tundra is loud and obvious.";
            tundra.MakeEngineNoise();
            tundra.MakeHonkNoise();
            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");

            Console.WriteLine();
            Console.WriteLine("____________________");
            Console.WriteLine();

            Car mustang = new Car();
            lot.CarList.Add(mustang);

            mustang.Year = 2011;
            mustang.Make = "Ford";
            mustang.Model = "GT";
            mustang.EngineNoise = "The engine noise is impressive on the GT.";
            mustang.HonkNoise = "The honk of a mustang is ehh to be honest.";
            mustang.MakeEngineNoise();
            mustang.MakeHonkNoise();
            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");

            Console.WriteLine();
            Console.WriteLine("____________________");
            Console.WriteLine();

            Car focus = new Car();
            lot.CarList.Add(focus);

            focus.Year = 2023;
            focus.Make = "Ford";
            focus.Model = "Focus";
            focus.EngineNoise = "The engine noise on a focus is pretty much nonexistant.";
            focus.HonkNoise = "The honk of a Focus is absolutely embarrassing. Dont use it if you can help it.";
            focus.MakeEngineNoise();
            focus.MakeHonkNoise();
            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");

            Console.WriteLine();
            Console.WriteLine("____________________");
            Console.WriteLine();

            foreach(var car in lot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} | Make: {car.Make} | Model: {car.Model}");
            }

            Console.WriteLine();
            Console.WriteLine("____________________");
            Console.WriteLine();
            Console.WriteLine($"The total number of cars in the lot is: {CarLot.numberOfCars}");
















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
        }
    }
}
