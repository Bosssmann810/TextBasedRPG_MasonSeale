using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG_MasonSeale
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };

        static void Main(string[] args)
        {
            display();
            Console.ReadKey(true);
            display(1);
            Console.ReadKey(true);
            display("");
            Console.ReadKey(true);
        }
        static void display()
        {
            Console.Write("+------------------------------+");
            for(int i = 0; i < map.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.Write("|");

            }
            Console.WriteLine();
            Console.WriteLine("+------------------------------+");
        }
        static void display(int x)
        {
            Console.Write("+------------------------------------------------------------+");
            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                    Console.Write(map[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
                Console.Write("|");

                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                    Console.Write(map[i, j]);
                }
                Console.Write("|");

            }
            Console.WriteLine();
            Console.WriteLine("+------------------------------------------------------------+");

        }
        static void display(string x)
        {
            Console.Write("+------------------------------------------------------------------------------------------+");
            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                    Console.Write(map[i, j]);
                    Console.Write(map[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                    Console.Write(map[i, j]);
                    Console.Write(map[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                    Console.Write(map[i, j]);
                    Console.Write(map[i, j]);
                }
                Console.Write("|");
            }
            Console.WriteLine();
            Console.Write("+------------------------------------------------------------------------------------------+");

        }
    }


}
