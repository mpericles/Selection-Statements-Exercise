using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
            //var r = new Random();
            //var favNumber = r.Next(1, 1000);
            var favNumber = 50;

            // The following code will allow the user to guess what your favorite number is (be sure to prompt the user what to input):
            Console.WriteLine("Please input a number");
            var userInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"This is the number that is my Favorite Number {favNumber}");
            Console.WriteLine("Now we are checking whether the number is too low(below 50), high(larger than 50) or guessed correctly");

            //Create an if-statement that if the guessed number is below the initial value, print out “too low”.
            //Create an else -if statement that if the number is higher than the initial value, print out “too high”.
            //Create an else statement that prints out some type of congratulations for guessing the correct number e.g. “You guessed it!!!”.
            if (userInput < 50)
                {
                Console.WriteLine($"This is the number that was inputed {userInput}");
                Console.WriteLine("The number provided was too low");
                //Console.WriteLine("too Low");
                }
                else if(userInput > 50)
                {
                Console.WriteLine($"This is the number that was inputted {userInput}");
                Console.WriteLine("The number provided was too high");
                //Console.WriteLine("too High");
                }
                else
                {
                Console.WriteLine("You Guess it!!!");
                 }
                       
        }
    }
}
