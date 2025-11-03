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
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','^'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`','^'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`','^'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','^'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
    };

        static void Main(string[] args)
        {
            legend();
            display();
            Console.ReadKey(true);
            display(2);
            Console.ReadKey(true);
            display(3);
            Console.ReadKey(true);
        }

       
        static void display(int x = 1)
        {
            if (x == 1)
            {
                Console.Write("+-------------------------------+");
                for (int i = 0; i < map.GetLength(0); i++)
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
                Console.WriteLine("+-------------------------------+");
            }
            if (x == 2)
            {
                Console.Write("+--------------------------------------------------------------+");
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
                Console.WriteLine("+--------------------------------------------------------------+");
            }
            if (x == 3)
            {
                Console.Write("+---------------------------------------------------------------------------------------------+");
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
                Console.Write("+---------------------------------------------------------------------------------------------+");

            }

        }
  
        static void legend()
        {
            Console.WriteLine("Legend:");
            Console.WriteLine("' = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("^ = mountain");
        }
    }


}
