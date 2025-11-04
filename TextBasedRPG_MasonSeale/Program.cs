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
            Console.WriteLine();
            legend();
            display();
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            legend();
            display(2);
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            legend();
            display(3);
            Console.ReadKey(true);
        }

       
        static void display(int x = 1)
        {
            if (x == 1)
            {
               
                Console.Write("+");
                string current = string.Concat(Enumerable.Repeat("-", map.GetLength(1)));
                Console.Write(current);
                Console.Write("+");
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    Console.WriteLine();
                    Console.Write("|");
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i,j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                        }
                        if (map[i,j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(map[i, j]);
                        }
                        if (map[i,j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                        }
                        if (map[i,j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                        }
                        
                        
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");

                }
                Console.WriteLine();
                Console.Write("+");
                Console.Write(current);
                Console.Write("+");
            }
            if (x == 2)
            {
                Console.Write("+");
                string current = string.Concat(Enumerable.Repeat("-", map.GetLength(1) * 2));
                Console.Write(current);
                Console.Write("+");
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    Console.WriteLine();
                    Console.Write("|");
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                    Console.WriteLine();
                    Console.Write("|");

                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");

                }
                Console.WriteLine();
                Console.Write("+");
                Console.Write(current);
                Console.Write("+");
            }
            if (x == 3)
            {
                Console.Write("+");
                string current = string.Concat(Enumerable.Repeat("-", map.GetLength(1) * 3));
                Console.Write(current);
                Console.Write("+"); 
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    Console.WriteLine();
                    Console.Write("|");
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                    Console.WriteLine();
                    Console.Write("|");
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                    Console.WriteLine();
                    Console.Write("|");
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                }
                Console.WriteLine();
                Console.Write("+");
                Console.Write(current);
                Console.Write("+");

            }

        }
  
        static void legend()
        {

            Console.WriteLine("┌────────────┐");
            Console.WriteLine("│Legend:     │");
            Console.Write("│");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("' = grass   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("│");
            Console.WriteLine();
            Console.Write("│");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("~ = water   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("│");
            Console.WriteLine();
            Console.Write("│");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("^ = mountain");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("│");
            Console.WriteLine();
            Console.Write("│");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("* = forest  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("│");
            Console.WriteLine();
            Console.Write("└────────────┘");
            Console.WriteLine();
        }
    }


}
