using System;
using System.IO.Pipes;
using System.Runtime.Intrinsics.X86;

namespace TestDeliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = 0.0;
            double b = 0.0;

            Console.WriteLine("Hi. Welcome to Andrew's BBQ Buffet. All you can eat for $9.99! " +
                "We only charge extra for beer, which is $4.00. how many people are in your group? " +
                "Please, parties of 6 or fewer.");
            double group = double.Parse(Console.ReadLine());

            if (group >= 1 && group <= 6)
            {
                Console.WriteLine("\nA table for " + group + "! Please follow me and take a seat. " +
                    "Let's get in your drink orders. We have water or beer.");

                for (double person = 1; person <= group; person++)
                {
                    Console.WriteLine("\nAlright, person number " + person + ", would you like water or beer?");
                    string drink = (Console.ReadLine());

                    string[] response = new[] {"Ok, one " + drink + ".\n",
                                         "One " + drink + ". You got it.\n",
                                         "A " + drink + ". Good choice.\n",
                                         drink + ". Okay, sounds good.\n",
                                         "No problem. One " + drink + ".\n",
                                         "Alright, one " + drink + ".\n"};

                    Random rnd = new Random();
                    int rng = rnd.Next(0, 5);

                    if (drink == "water" || drink == "Water")
                    {
                        Console.WriteLine(response[rng]);
                        w++;
                    }
                    else if (drink == "beer" || drink == "Beer")
                    {
                        Console.WriteLine(response[rng]);
                        b++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we don't have " + drink + ". I won't bring a drink for you, " +
                            "but let me know if you change your mind.\n");
                    }
                }
                Console.WriteLine("\nGreat! So that's " + w + " waters and " + b + " beers. While I " +
                    "grab those drinks for you, feel free to head to the buffet!\n");

                double group2 = group * 9.99;
                double b2 = b * 4.0;
                double bill = group2 + b2;

                Console.WriteLine("\nThanks for stopping in, today! Here's your bill. Total price: $" + bill +
                    ". Have a great day!");
            }
            else if (group > 6)
            {
                Console.WriteLine("\nSorry, we can only accommodate groups up to 6 people. Have a nice day!");
            }
        }
    }
}