using System;
using System.Linq;

namespace SwissFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type dimensions: between 21 and 41");
            int dimension = Convert.ToInt32(Console.ReadLine());

            if (dimension>= 21&& dimension<=41)
            {
                DrawSwissFlag(dimension);
            }
            else
            {
                Console.WriteLine("Error. Type again!");
            }

            Console.WriteLine("Have a look at your ticket! Is it lucky?");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckLucky(input));
            Console.ReadLine();


        }

        static void DrawSwissFlag(int dimension)
        {
            int crossFrame = dimension / 4;
            int side = (dimension - crossFrame * 2) / 3;
            for (var i = 0; i < dimension; i++)
            {
                
                //First and last (crossFrame)'s strings
                if (i < crossFrame || i >= crossFrame + side * 3)
                {
                    Console.WriteLine(new string('*', dimension));
                    
                }
                //Cross part strings - cross centre
                else if ((i >= crossFrame && i < crossFrame + side) || (i > crossFrame + side * 2 && i < crossFrame + side * 3))
                {

                    Console.WriteLine(
                        $"{new string('*', crossFrame + side)}" +
                        $"{new string(' ', side)}" +
                        $"{new string('*', dimension - crossFrame - side * 2)}"
                        );

                }
                //Cross center
                else
                {

                    Console.WriteLine(
                        $"{new string('*', crossFrame)}" +
                        $"{new string(' ', side * 3)}" +
                        $"{new string('*', dimension - crossFrame - side * 3)}"
                        );
                }
            }
        }


        static string CheckLucky(int ticket)
        {
            string result = "";

            int[] array = ticket.ToString().ToCharArray().Select(x => x - '0').ToArray();

            int[] leftPart = array.Take(array.Length/2).ToArray();
            int[] rightPart = array.Skip(array.Length/2).ToArray();

            if (leftPart.Sum() == rightPart.Sum())
            {
                result = "You're lucky!";
            }
            else
            {
                result = "You looose!";
            }



            return result;
        }
    }
}
