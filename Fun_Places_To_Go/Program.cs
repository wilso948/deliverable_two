using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Places_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {



            string userInput1, userChoice1, userChoice2, userChoice3, userChoice4;
            int userInput2;

            Console.WriteLine(("Hello User!") + (" Welcome to MY world now."));
            Console.ReadKey();

            Console.WriteLine(("What are you in the mood for?:") + (" Your options are listed below:"));
            Console.ReadKey();


            Console.WriteLine("a.) Action");
            Console.WriteLine("b.) Chill times");
            Console.WriteLine("c.) Danger");
            Console.WriteLine("d.) Good Food");
            Console.WriteLine("Choose an option");
            userInput1 = Console.ReadLine();

            Console.WriteLine("Whats the squad number?");
            int.TryParse(Console.ReadLine(), out userInput2);

            userChoice1 = "Action";
            userChoice2 = "chill times";
            userChoice3 = "danger";
            userChoice4 = "good food";
             



            if (userInput1 == "a" && userInput2 == 0) 
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice1 + (". Then you should go Stock Car Racing and travel in sneakers!"));
            }
            else if ( userInput1 == "a" && userInput2 >= 1 && userInput2 <= 4)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice1 + (". Then you should go Stock Car Racing and travel in a Sedan!"));
            }
            else if (userInput1 == "a" && userInput2 >= 5 && userInput2 <= 10)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice1 + (". Then you should go Stock Car Racing and travel in a Volkswagen bus!"));
            }
            else if (userInput1 == "a" && userInput2 >= 11)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice1 + (". Then you should go Stock Car Racing and travel in an airplane!"));
            }
            else if (userInput1 == "b" && userInput2 == 0)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice2 + (". Then you should go hiking and travel in sneakers!"));
            }
            else if (userInput1 == "b" && userInput2 >= 1 && userInput2 <= 4)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice2 + (". Then you should go hiking and travel in a Sedan!"));
            }
            else if (userInput1 == "b" && userInput2 >= 5 && userInput2 <= 10)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice2 + (". Then you should go hiking and travel in a Volkswagen bus!"));
            }
            else if (userInput1 == "b" && userInput2 >= 11)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice2 + (". Then you should go hiking and travel in an airplane!"));
            }
            else if (userInput1 == "c" && userInput2 == 0)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice3 + (". Then you should go skydiving and travel in sneakers!"));
            }
            else if (userInput1 == "c" && userInput2 >= 1 && userInput2 <= 4)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice3 + (". Then you should go skydiving and travel in a Sedan!"));
            }
            else if (userInput1 == "c" && userInput2 >= 5 && userInput2 <= 10)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice3 + (". Then you should go skydiving and travel in a Volkswagen bus!"));
            }
            else if (userInput1 == "c" && userInput2 >= 11)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice3 + (". Then you should go skydiving and travel in an airplane!"));
            }
            else if (userInput1 == "d" && userInput2 == 0)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice4 + (". Then you should go to Taco Bell and travel in sneakers!"));
            }
            else if (userInput1 == "d" && userInput2 >= 1 && userInput2 <= 4)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice4 + (". Then you should go to Taco Bell and travel in a Sedan!"));
            }
            else if (userInput1 == "d" && userInput2 >= 5 && userInput2 <= 10)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice4 + (". Then you should go to Taco Bell and travel in a Volkswagen bus!"));
            }
            else if (userInput1 == "d" && userInput2 >= 11)
            {
                Console.WriteLine(("If you are in the mood for ") + userChoice4 + (". Then you should go to Taco Bell and travel in an airplane!"));
            }
            else
            {
                Console.WriteLine("Input not understood, please try again!");
            }

            Console.WriteLine("Goodbye!");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();






        }
    }
}
