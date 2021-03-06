﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Knight_Game
{
    public class Program
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            char[][] field = new char[size][];

            for (int row = 0; row < field.Length; row++)
            {
                var inputRow = Console.ReadLine();
                field[row] = new char[size];
                for (int col = 0; col < field[row].Length; col++)
                {
                    field[row][col] = inputRow[col];
                }
            }
            var moves = 0;
            //checker
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'K')
                    {

                        if (col - 2 >= 0 && row + 1 <= field.Length - 1 && field[row + 1][col - 2] == 'K')
                        {
                            field[row + 1][col - 2] = '0';
                            moves++;

                        }
                        if (col - 2 >= 0 && row - 1 >= 0 && field[row - 1][col - 2] == 'K')
                        {
                            field[row - 1][col - 2] = '0';
                            moves++;

                        }
                        if (col + 2 <= field[row].Length - 1 && row + 1 <= field.Length - 1 && field[row + 1][col + 2] == 'K')
                        {
                            field[row + 1][col + 2] = '0';
                            moves++;

                        }
                        if (col + 2 <= field[row].Length - 1 && row - 1 >= 0 && field[row - 1][col + 2] == 'K')
                        {
                            field[row - 1][col + 2] = '0';
                            moves++;

                        }
                        //rows checker
                        if (row + 2 <= field.Length - 1 && col - 1 >= 0 && field[row + 2][col - 1] == 'K')
                        {
                            field[row + 2][col - 1] = '0';
                            moves++;

                        }
                        if (row + 2 <= field.Length - 1 && col + 1 <= field[row].Length - 1 && field[row + 2][col + 1] == 'K')
                        {
                            field[row + 2][col + 1] = '0';
                            moves++;

                        }
                        if (row - 2 >= 0 && col - 1 >= 0 && field[row - 2][col - 1] == 'K')
                        {
                            field[row - 2][col - 1] = '0';
                            moves++;
                        }
                        if (row - 2 >= 0 && col + 1 <= field.Length - 1 && field[row - 2][col + 1] == 'K')
                        {
                            field[row - 2][col + 1] = '0';
                            moves++;
                        }                    
                    }
                    
                }
            }

            Console.WriteLine(moves);
        }
    }
}
