using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //........first question
            // I asked the user to provide 2 numbers
            //Console.WriteLine("Please enter 2 whole numbers.");
            //Console.WriteLine("Enter your first number.");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your second number.");
            //int secondNumber = int.Parse(Console.ReadLine());

            //I then ran a conditional statement to find out if the 2 numbers
            // are equal or not.  Then I printed the correct answer
            //if(firstNumber == secondNumber)
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are the same number.");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are not the same number."); 

            //..........question 2
            //I asked the user for a number to determine if it is an even or odd number
            //Console.WriteLine("Please enter a number to tell if it is an even or odd number.");
            //double typeNumber = double.Parse(Console.ReadLine());

            ////to determine whether of not a number is an even or odd number, I used the
            ////the remainder operation to see if the number had a remainder after being
            ////divided by 2.  Then printed to the screen
            //if((typeNumber % 2) == 0)
            //{
            //    Console.WriteLine("Your number is an even number.");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is an odd number.");
            //}

            //...........question 3
            //I asked the user to provide a number to tell if it is positive or not
            //Console.WriteLine("Please enter a number to determine if it is a positive" +
            //    " or negative number.");
            //int number = int.Parse(Console.ReadLine());

            ////used if, else if statement to determine if the number is a positive
            ////negative, or an zero...which is neither positive or negative
            ////Then printed it to the screen
            //if(number > 0)
            //{
            //    Console.WriteLine(number + " is a positive number.");
            //}
            //else if(number < 0)
            //{
            //    Console.WriteLine(number + " is a negative number.");
            //}
            //else
            //{
            //    Console.WriteLine("Your number " + number + " is neither positive or negative.");
            //}

            //..........question 4
            //I asked the user to provide a letter to see if it is a vowel or not
            //Console.WriteLine("Please enter a letter to see if it is a vowel or consonant.");
            //string letter = (Console.ReadLine());

            ////Determined whether the user provided letter is a vowel or not 
            ////using the if else statement. Then printed it to the screen
            //if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u"
            //   || letter == "A" || letter == "E" || letter == "I" || letter == "O" || letter == "U")
            //{
            //    Console.WriteLine("The letter " + letter + " is a vowel.");
            //}
            //else
            //{
            //    Console.WriteLine("The letter " + letter + " is a consonant.");
            //}

            //........question 5
            //I asked the user to enter 2 numbers to determine which one is the greatest.
            //Console.WriteLine("Please provide 2 numbers to find out which one is the greatest.");
            //Console.WriteLine("Enter your first number.");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your second number.");
            //int secondNumber = int.Parse(Console.ReadLine());


            ////I used the if statement to print to the screen which number is the greatest
            //if (firstNumber > secondNumber)
            //{
            //    Console.WriteLine(firstNumber + " is the greatest number.");
            //}
            //else
            //{
            //    Console.WriteLine(secondNumber + " is the greatest number.");
            //}

            //.......BONUS question 5
            //I asked the user to supply 3 integers to determine the greatest one.
            //Console.WriteLine("Please provide 3 nubmers to find out which one is the greatest.");
            //Console.WriteLine("Enter your first number.");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your second number.");
            //int secondNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your third number.");
            //int thirdNumber = int.Parse(Console.ReadLine());


            ////I used if else if statements to print to the screen which integer of the 3 that
            ////is the greatest.
            //if (firstNumber > secondNumber && firstNumber > thirdNumber)
            //{
            //    Console.WriteLine(firstNumber + " is the greatest number.");
            //}
            //else if(secondNumber > firstNumber && secondNumber > thirdNumber)
            //{
            //    Console.WriteLine(secondNumber + " is the greatest number.");
            //}
            //else
            //{
            //    Console.WriteLine(thirdNumber + " is the greatest number.");
            //}

            //.........question 6
            //I asked the user to input 4 numbers in order to determine thier mean value
            Console.WriteLine("Please enter in 4 numbers to determine the mean.");
            Console.WriteLine("Enter in your first number.");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter in your second number.");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter in your third number.");
            double thirdNumber = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter in your fourth number.");
            double fourthNumber = double.Parse(Console.ReadLine());

            //next I determined their mean value
            double totalAmount = (firstNumber + secondNumber + thirdNumber + fourthNumber);
            double meanNumber = totalAmount / 4;

            //Printed it to the screen
            Console.WriteLine("The mean of your numbers is " + meanNumber);



        }
    }
}
