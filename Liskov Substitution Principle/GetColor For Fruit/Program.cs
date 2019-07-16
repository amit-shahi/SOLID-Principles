using System;
using static System.Console;

namespace Liskov_Substitution_Principle
{
    //// Wrong Way
    // public class Apple
    // {
    //     public virtual string GetColor()
    //     {
    //         return "Red";
    //     }
    // }
    // public class Orange : Apple
    // {
    //     public override string GetColor()
    //     {
    //         return "Orange";
    //     }
    // }


    //// Correct way using Abstract class and right substitutable base class 
    
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

    public class Banana : Fruit
    {
        public override string GetColor()
        {
            return "Yellow";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            //// Wrong way

            // Apple apple = new Orange();
            // Console.WriteLine(apple.GetColor());


            //// Correct way

            Fruit fruit = new Orange();

            WriteLine(fruit.GetColor()); // returns Orange Color as -> Orange
            
            fruit = new Apple();

            WriteLine(fruit.GetColor()); // returns Apple Color as -> Red

            fruit = new Banana();

            WriteLine(fruit.GetColor()); // returns Banana Color as -> Yellow 

        }
    }
}
