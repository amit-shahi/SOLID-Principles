using System;
using static System.Console;

namespace Car_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Car Inheritance Sample to Explain Liskov Substritution Principle");
            WriteLine("----------------------------------------------------------------");
            WriteLine();

            bool IsRunning = true;


            // Test Cases:
            // 1. WagonR is not a sedan and has 4 seats.
            // 2. HondaCity is a sedan and has 4 seats.
            // 3. InnovaCrysta is not a sedan and has 6 seats.


            // Taken Input from user for
            // 1. Type of Car Eg. 
            //    0 - WagonR, 1 - HondaCity, 2 - InnovaCrysta
            // 2. Mileage of Car
            //    Should be between 5 and 30 kmpl


            while (IsRunning)
            {
                try
                {
                    WriteLine();
                    WriteLine("Available Car Type: ");
                    WriteLine("Type -  Name");

                    // TODO: Display List from some static List collection

                    WriteLine($"0 -     {CarType.WagonR}");
                    WriteLine($"1 -     {CarType.HondaCity}");
                    WriteLine($"2 -     {CarType.InnovaCrysta}");

                    WriteLine();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Press any key to Continue or Esc Key to exit.");
                    if (ReadKey().Key == ConsoleKey.Escape)
                    {
                        IsRunning = false;
                        ForegroundColor = ConsoleColor.White;
                        break;
                    }

                    ForegroundColor = ConsoleColor.White;

                    WriteLine();
                    WriteLine();
                    WriteLine("Enter Type of Car.");

                    int carType = Convert.ToInt32(Console.ReadLine().Trim());

                    if (carType < 0 || carType > 2)
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Invalid Car Type entered. Please enter correct Car Type (0-2)");
                        
                        ForegroundColor = ConsoleColor.White;
                        IsRunning = false;
                    }



                    WriteLine();

                    WriteLine("Enter Car Mileage.");

                    int carMileage = Convert.ToInt32(Console.ReadLine().Trim());

                    if (carMileage < 5 || carMileage > 30)
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Invalid Car Mileage entered. Please enter appropriate Mileage (5-30).");
                        ForegroundColor = ConsoleColor.White;
                        IsRunning = false;
                    }

                    WriteLine();

                    
                    // Check the Car Type and Show it's Mileage in below format
                    // A {CarType} is not Sedan, is {NoOfSeats}-seater, and has a mileage of around {Mileage} kmpl.
                    // A {CarType} is Sedan, is {NoOfSeats}-seater, and has a mileage of around {Mileage} kmpl.


                    // I could Implement Abstract Factory Pattern here and let my Factory Class create and give me an instance of Car as per entered Car Type.

                    ForegroundColor = ConsoleColor.Green;

                    switch (carType)
                    {
                        case 0:
                            ICar wagonR = new WagonR(carMileage);
                            WriteLine(wagonR.Print(CarType.WagonR));
                            break;
                        case 1:
                            ICar hondaCity = new HondaCity(carMileage);
                            WriteLine(hondaCity.Print(CarType.HondaCity));
                            break;
                        case 2:
                            ICar innovaCrysta = new InnovaCrysta(carMileage);
                            WriteLine(innovaCrysta.Print(CarType.InnovaCrysta));
                            break;

                    }

                    ForegroundColor = ConsoleColor.White;
                }
                catch (Exception ex)
                {
                    WriteLine($"{ex.GetType()} : {ex.Message} ");
                }
            }

        }
    }
}
