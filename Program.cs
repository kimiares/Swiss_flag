using System;

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


            Console.ReadLine();
        }

        static void DrawSwissFlag(int dimension)
        {
            int crossFrame = dimension / 4;
            int side = (dimension - crossFrame * 2) / 3;
            for (var i = 0; i < dimension; i++)
            {
                if (i < crossFrame || i >= crossFrame + side * 3)
                {
                    Console.WriteLine(new string('*', dimension));
                }
                else if ((i >= crossFrame && i < crossFrame + side) || (i > crossFrame + side * 2 && i < crossFrame + side * 4))
                {

                    Console.WriteLine(
                        $"{new string('*', crossFrame + side)}" +
                        $"{new string(' ', side)}" +
                        $"{new string('*', dimension - crossFrame - side * 2)}"
                        );

                }
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
    }
}
