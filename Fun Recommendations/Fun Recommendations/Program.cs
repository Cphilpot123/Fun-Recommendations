using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Recommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, what are you in the mood for?");
            Console.WriteLine("Here are your options:");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chilling");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good Food");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("You should go Stock Car Racing");

            }
            if (input == 2)
            {
                Console.WriteLine("You should go Hicking");
            }
            if (input == 3)
            {
                Console.WriteLine("You should go Skydiving");
            }
            if (input == 4)
            {
                Console.WriteLine("You should go To Taco Bell");
            }
            if (input > 4)
            {
                Console.WriteLine("Not an available option");
         
            }
            Console.WriteLine("How many people are you bringing with you?");
            int inputwo = Convert.ToInt32(Console.ReadLine());

            if (input == 1 && inputwo == 0)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in sneakers");

            }
            if (input == 1 && inputwo == 2)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in a sedan");

            }
            if (input == 1 && inputwo == 3)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in a sedan");
            }
            if (input == 1 && inputwo == 4)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in a sedan");
            }


            if (input == 2 && inputwo == 0)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in sneakers");
            }
            if (input == 2 && inputwo == 1)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in a sedan");
            }
            if (input == 2 && inputwo == 2)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in sneakers");
            }
            if (input == 2 && inputwo == 3)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in a sedan");
            }
            if (input == 2 && inputwo == 4)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in a sedan");
            }


            if (input == 3 && inputwo == 0)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in sneakers");
            }
            if (input == 3 && inputwo == 1)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in a sedan");
            }
            if (input == 3 && inputwo == 2)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in sneakers");
            }
            if (input == 3 && inputwo == 3)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in a sedan");
            }
            if (input == 3 && inputwo == 4)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in a sedan");
            }


            if (input == 4 && inputwo == 0)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in sneakers");
            }
            if (input == 4 && inputwo == 1)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in a sedan");
            }
            if (input == 4 && inputwo == 2)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in sneakers");
            }
            if (input == 4 && inputwo == 3)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in a sedan");
            }
            if (input == 4 && inputwo == 4)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in a sedan");
            }

            if (input == 1 && inputwo == 5)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in a Volkswagen");

            }
            if (input == 1 && inputwo == 6)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in a Volkswagen");

            }
            if (input == 1 && inputwo == 7)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in a Volkswagen");
            }
            if (input == 1 && inputwo == 8)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in a Volkswagen");
            }
            if (input == 1 && inputwo == 9)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in a Volkswagen");
            }
            if (input == 1 && inputwo == 10)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel in a Volkswagen");
            }



            if (input == 2 && inputwo == 5)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in a Volkswagen");
            }
            if (input == 2 && inputwo == 6)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in a Volkswagen");
            }
            if (input == 2 && inputwo == 7)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in a Volkswagen");
            }
            if (input == 2 && inputwo == 8)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in a Volkswagen");
            }
            if (input == 2 && inputwo == 9)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in a Volkswagen");
            }
            if (input == 2 && inputwo == 10)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel in a Volkswagen");
            }

            if (input == 3 && inputwo == 5)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in a Volkswagen");
            }
            if (input == 3 && inputwo == 6)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in a Volkswagen");
            }
            if (input == 3 && inputwo == 7)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in a Volkswagen");
            }
            if (input == 3 && inputwo == 8)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in a Volkswagen");
            }
            if (input == 3 && inputwo == 9)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in a Volkswagen");
            }
            if (input == 3 && inputwo == 10)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel in a Volkswagen");
            }

            if (input == 4 && inputwo == 5)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in a Volkswagen");
            }
            if (input == 4 && inputwo == 6)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in a Volkswagen");
            }
            if (input == 4 && inputwo == 7)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in a Volkswagen");
            }
            if (input == 4 && inputwo == 8)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in a Volkswagen");
            }
            if (input == 4 && inputwo == 9)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in a Volkswagen");
            }
            if (input == 4 && inputwo == 10)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel in a Volkswagen");
            }

            if (input == 1 && inputwo > 10)
            {
                Console.WriteLine("Okay, for Action and Stock Car Racing, you should travel on an airplane");
            }
            if (input == 2 && inputwo > 10)
            {
                Console.WriteLine("Okay, for Chilling and Hiking, you should travel on an airplane");
            }
            if (input == 3 && inputwo > 10)
            {
                Console.WriteLine("Okay, for Danger and Skydiving, you should travel on an airplane");
            }
            if (input == 4 && inputwo > 10)
            {
                Console.WriteLine("Okay, for Good Food at Taco Bell, you should travel on an airplane");
            }



            if (input > 4 && inputwo == 0)
            {
                Console.WriteLine("Wherever you go, you should travel in on sneakers");
            }
            if (input > 4 && inputwo == 1)
            {
                Console.WriteLine("Wherever you go, you should travel inn a sedan");
            }
            if (input > 4 && inputwo == 2)
            {
                Console.WriteLine("Wherever you go, you should travel inn a sedan");
            }
            if (input > 4 && inputwo == 3)
            {
                Console.WriteLine("Wherever you go, you should travel inn a sedan");
            }
            if (input > 4 && inputwo == 4)
            {
                Console.WriteLine("Wherever you go, you should travel inn a sedan");
            }

            if (input > 4 && inputwo == 5)
            {
                Console.WriteLine("Wherever you go, you should travel in on sneakers");
            }
            if (input > 4 && inputwo == 6)
            {
                Console.WriteLine("Wherever you go, you should travel in a Volkswagen");
            }
            if (input > 4 && inputwo == 7)
            {
                Console.WriteLine("Wherever you go, you should travel in a Volkswagen");
            }
            if (input > 4 && inputwo == 8)
            {
                Console.WriteLine("Wherever you go, you should travel in a Volkswagen");
            }
            if (input > 4 && inputwo == 9)
            {
                Console.WriteLine("Wherever you go, you should travel in a Volkswagen");
            }
            if (input > 4 && inputwo == 10)
            {
                Console.WriteLine("Wherever you go, you should travel in a Volkswagen");
            }
            if (input > 4 && inputwo > 10)
            {
                Console.WriteLine("Wherever you go, you should travel in on a airplane");
            }

            
            Console.WriteLine("Hope you have a nice day!");
            Console.ReadKey();
        }
    }
}
