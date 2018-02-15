using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleName;
            string lastName;
            int heightFeet;
            int heightInches;
            bool isCitizen;
            bool isEighteen;
            string eighteenInput;
            string citizenInput;
            string canYouVote;

            System.Console.Write("Who are you? I must get some information about you before you may vote! \nWhat is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Sounds good, but what about your middle name or initial? ");
            middleName = System.Console.ReadLine();

            System.Console.Write("Okay, now what is your last name? ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine("Hello there, " + firstName + " " + middleName + " " + lastName + "!");

            System.Console.Write("Now, how tall are you in feet? Please enter a numeral for this. ");
            heightFeet = int.Parse(Console.ReadLine());

            System.Console.Write("And how tall are you in inches? A numeral like before. ");
            heightInches = int.Parse(Console.ReadLine());

            System.Console.WriteLine("So, you are " + heightFeet + " feet and " + heightInches + " inches tall.\n");

            int heightFeetToInches = heightFeet * 12;

            int sum = heightInches + heightFeetToInches;

            System.Console.WriteLine($"In other words, you are {sum * 2.54} centimeters!");

            System.Console.Write("Now, please answer true or false to the following question:\n");

            System.Console.Write("Are you at least eighteen years old? ('True' for yes, 'False' for no) ");
            eighteenInput = System.Console.ReadLine();
            isEighteen = System.Convert.ToBoolean(eighteenInput);
            System.Console.WriteLine("You have entered " + isEighteen);

            System.Console.Write("Are you a US citizen? ('True' for yes, 'False' for no) ");
            citizenInput = System.Console.ReadLine();
            isCitizen = System.Convert.ToBoolean(citizenInput);
            System.Console.WriteLine("You have entered " + isCitizen);
           
            canYouVote = (isEighteen && isCitizen) ? "Congratulations! You may vote!" : "Sorry, you may not vote!";
            System.Console.WriteLine(canYouVote);
                        
            System.Console.WriteLine("Please press any key to continue.");
            System.Console.ReadKey();
            
        }
    }
}
