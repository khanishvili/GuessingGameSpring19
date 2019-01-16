using System;

namespace GuessingGameSpring19
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("PLease gues a Number between 1 to 10 or 0 for Help");
            string userguess = Console.ReadLine();
            if (userguess.Equals("0"))
            {
                Console.WriteLine("=========Instructions=========");
                Console.WriteLine("Gueas a Number between 1 to 10");
                Console.WriteLine("hit enter to submit your guess");
            }
            else if (userguess.Equals("7")) 
                {
                Console.WriteLine("u won the game");
            }
            else
            {
                Console.WriteLine("You lost");
            }

        }
    } }
