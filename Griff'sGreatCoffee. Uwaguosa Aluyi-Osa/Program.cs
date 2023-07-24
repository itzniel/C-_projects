//Author : Uwaguosa Aluyi-Osa
//Title : Assignment 1
//Date started : 2022-06-03
//Date last modified: 2022-06-05
 
using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)

           {//Declare variable and assign value
            // Varaibles for coffeeSelection
            int small = 3;
            int medium = 5;
            int large = 7;
            
                Console.WriteLine("Welcome to Griff's Great Coffee!");
                Console.WriteLine("The following are available small coffee: $3, medium coffee: $7, and large coffee: $8");
                //Get input from customer
                //Declare customer's name
                Console.Write("Enter customer's first name: ");
                //Input customer's first name
                string firstName = Console.ReadLine();
                Console.Write("Enter customer's given name: ");
                //Input customer's last name
                string givenName = Console.ReadLine();
                //Declare the coffee selected
                Console.WriteLine("Enter Coffee selection: ");
                //Input coffee size
                string coffeeSelection = Console.ReadLine();
                //Assign the small, medium, and large to the coffeeSelection string
                if (coffeeSelection == "small")
                    {
                    Console.WriteLine("Coffee price is $" + small);
                    //Declare tip variables
                    Console.Write("Enter tip if any 0%, 15%, and 20%: ");
                    //Input tip rate
                    double tipRate = Convert.ToDouble(Console.ReadLine()); 
                    //Assign variables to tip double, tax double, and amount double 
                    //processing calculations
                    double tip = small*tipRate*0.01;
                    double tax = small *0.13; 
                    double total; total = small + tax + tip;
                    //Display customer's name
                    Console.WriteLine("Bill for "+firstName+" " + givenName);
                    //Display coffee price
                    Console.WriteLine("Coffee price:$" +small);
                    //Display tax for the coffee selected
                    Console.WriteLine("HST:$" +tax);
                    //Display Total amount
                    Console.WriteLine("Total Amount Due is $" +total);
                    }
                else if (coffeeSelection =="medium")
                    {
                    Console.WriteLine("Coffee price is $" +medium);
                    //Declare tip variables
                    Console.Write("Enter tip if any ranging from 0% 15%, and 20%: ");
                    //Input tip rate
                    double tipRate = Convert.ToDouble(Console.ReadLine());
                    //Assign variables to tip double, tax double, and amount double 
                    //processing calculations 
                    double tip = medium*tipRate*0.01;
                    double tax = medium *0.13; 
                    double total = medium + tax + tip;
                    //Display customer's name
                    Console.WriteLine("Bill for "+firstName+" " + givenName);
                    //Display coffee price
                    Console.WriteLine("Coffee price:$" +medium);
                    //Display tax for the coffee selected
                    Console.WriteLine("HST:$" +tax);
                    //Display Total amount
                    Console.WriteLine("Total Amount Due is $" +total);

                    }
                else if (coffeeSelection =="large")
                    {
                    Console.WriteLine("Coffee price is $" +large);
                    //Declare tip variables
                    Console.Write("Enter tip if any ranging from 0% 15%, and 20%: ");
                    //Input tip rate
                    double tipRate = Convert.ToDouble(Console.ReadLine());
                    //Assign variables to tip double, tax double, and amount double 
                    //processing calculations 
                    double tip = large*tipRate*0.01;
                    double tax = large *0.13; 
                    double total; total = large + tax + tip;
                    //Display customer's name
                    Console.WriteLine("Bill for "+firstName+" " + givenName);
                    //Display coffee price
                    Console.WriteLine("Coffee price:$" +large);
                    //Display tax for the coffee selected
                    Console.WriteLine("HST:$" +tax);
                    //Display Total amount
                    Console.WriteLine("Total Amount Due is $" +total);
                    }
                    //condition if customer,s request is none of the coffeeSelection
                else 
                {   
                    //Display not available if coffee selection is not among the coffeeSelection
                    Console.WriteLine("coffee selection not available");

                }
            













        } 
    }
}