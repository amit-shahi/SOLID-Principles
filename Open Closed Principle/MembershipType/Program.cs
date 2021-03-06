﻿using System;
using static System.Console;
using System.Collections.Generic;

namespace Open_Closed_Principle
{

    // Wrong way

    // public enum MembershipType
    // {
    //     Standard,
    //     Premium
    // }

    // public class Customer
    // {
    //     public int ID { get; set; }
    //     public string Name { get; set; }
    //     public MembershipType Membership { get; set; }
    // }
  
    // public class Order
    // {
    //     public decimal CalculatePrice(decimal price, Customer customer)
    //     {
    //         decimal result = 0;
    //         decimal DiscountPercent = 0.1M; // 10% discount
    //         switch (customer.Membership)
    //         {
    //             case MembershipType.Standard:
    //                 result = price;
    //                 break;
    //             case MembershipType.Premium:
    //                 result = price - (price * DiscountPercent);
    //                 break;
    //             default:
    //                 break;
    //         }
    //         return result;
    //     }
    // }


   

    // Correct way

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
       // public MembershipType Membership{ get; set; }
    }

    // define an abstract class with common abstract method
    public abstract class MembershipType 
    {
        public abstract decimal CalculatePrice(decimal price);
    }

    // Implement abstract class for it's standard memership implementation
    public class StandardMembership : MembershipType
    {
        public override decimal CalculatePrice(decimal price)
        {
            return price; // No discount is applied for this type of customer.
        }
    }

    // Implement abstract class for it's premium membership implementation
    public class PremiumMembership : MembershipType
    {
        public override decimal CalculatePrice(decimal price)
        {
            return price - (price * 0.1M); // 10% discount
        }
    }

    // Following Open-Closed principle

    public class GoldMembership : MembershipType
    {
        public override decimal CalculatePrice(decimal price)
        {
            return price - (price * 0.2M); // 20% discount
        }
    }

    // public class Order
    // {
    //     public int OrderId { get; set;}
    //     public int CustomerId {get; set;}
    //     public string CustomerName { get; set;}
    //     public decimal CalculatePrice(decimal price, Customer customer)
    //     {
    //         return customer.Membership.CalculatePrice(price);
    //     }
    // }

    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" Demo of Open Closed Principle");

            

            // Wrong way
            //Order orders = new Order();
            // decimal calc1 = orders.CalculatePrice(1000, new Customer() { ID=1, Name="Simon", Membership = MembershipType.Standard });


            // decimal calc2 = orders.CalculatePrice(1000, new Customer() { ID=1, Name="David", Membership = MembershipType.Premium });
 
            // WriteLine();

            // WriteLine(" Wrong way - Tightly Coupled - Hard to add new Membership Type in future");
            // WriteLine(" -----------------------------------------------------------------------");
            // WriteLine();
            // WriteLine($" Standard Customer Id# 1 has paid ${ calc1.ToString("#.##") } of $1000 with no discount. ");
            // WriteLine();
            // WriteLine($" Premium Customer Id# 2 has paid ${ calc2.ToString("#.##") } of $1000 with 10% discount. ");
            // WriteLine();


            // Correct Way
            MembershipType standard = new StandardMembership();

            decimal calc1 = standard.CalculatePrice(1000);

            MembershipType premium = new PremiumMembership();
            
            decimal calc2 = premium.CalculatePrice(1000);

            MembershipType gold = new GoldMembership();

            decimal calc3 = gold.CalculatePrice(1000);
 
            WriteLine();
            WriteLine($" Standard Customer Id# 1 has paid ${ calc1.ToString("#.##") } of $1000 with no discount.");
            WriteLine();
            WriteLine($" Premium Customer Id# 2 has paid ${ calc2.ToString("#.##") } of $1000 with 10% discount.");
            WriteLine();
            WriteLine(" Extended functionality using Open-Closed principle");
            WriteLine(" --------------------------------------------------");
            WriteLine();
            WriteLine($" Gold Customer Id# 3 has paid ${ calc3.ToString("#.##") } of $1000 with 20% discount. ");
            WriteLine();

          

        }
 
    }
}
