using System;

namespace CavityMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] grid = new string[n];
            char[,] map = new char[n, n];
            for (int grid_i = 0; grid_i < n; grid_i++)
            {
                grid[grid_i] = Console.ReadLine();

                for (int i = 0; i < grid[grid_i].Length; i++)
                {
                    map[grid_i, i] = Convert.ToChar(grid[grid_i].Substring(i, 1));
                }
            }

            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    int num = (int)map[i, j];

                    if (num > (int)map[i - 1, j]
                        && num > (int)map[i, j - 1]
                        && num > (int)map[i, j + 1]
                        && num > (int)map[i + 1, j])
                    {
                        map[i, j] = 'X';
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
