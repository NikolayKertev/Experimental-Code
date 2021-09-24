﻿using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[,] field = new char[26, 26]
            {
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', 'S', '█', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', ' ', ' ', ' ', '█', ' ', '█', ' ', '█', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', ' ', ' ', ' ', ' ', '█', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', ' ', ' ', ' ', ' ', '█', ' ', '█', ' ', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', ' ', '█', ' ', '█', ' ', ' ', '█', ' ', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', ' ', '█', ' ', ' ', '█', ' ', ' ', ' ', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', ' ', '█', '█', ' ', '█', ' ', ' ', ' ', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', ' ', '█', ' ', ' ', '█', ' ', ' ', ' ', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', ' ', ' ', ' ', '█', '█', ' ', ' ', ' ', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', ' ', '█', ' ', ' ', ' ', ' ', ' ', ' ', 'F', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
            };

            char[,] fields = new char[10, 10] 
            {
            {'S', '█', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', '█', ' ', '█', ' ', ' ', ' ', ' '},
            {'█', '█', '█', ' ', ' ', '█', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', ' '},
            {' ', '█', ' ', '█', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'F'},    
            };
            int currentRow = 0;
            int currentCol = 0;
            int madeMoves = 0;
            bool isAtFinal = false;

            //for (int row = 0; row < field.GetLength(0); row++)
            //{
            //    for (int col = 0; col < field.GetLength(1); col++)
            //    {
            //        field[row, col] = '.';
            //    }
            //}

            //field[0, 0] = 'S';
            //field[field.GetLength(0) - 1, field.GetLength(1) - 1] = 'F';

            while (true)
            {
                Console.WriteLine("Type 'w', 'a', 's', 'd' in order to move!");
                Console.WriteLine("Get to the exit with as less possible moves!");
                Console.WriteLine();

                for (int row = 0; row < field.GetLength(0); row++)
                {
                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        if (field[row, col] == 'S')
                        {
                            currentRow = row;
                            currentCol = col;
                        }

                        Console.Write(field[row, col] + " ");
                    }
                    Console.WriteLine();
                }

                string input = Console.ReadLine();

                if (input == "a" && currentCol - 1 >= 0 && currentCol < field.GetLength(1) && currentRow >= 0 && currentRow < field.GetLength(0))
                {
                    if (field[currentRow, currentCol - 1] == 'F')
                    {
                        isAtFinal = true;
                    }

                    field[currentRow, currentCol] = '.';
                    field[currentRow, currentCol - 1] = 'S';
                    madeMoves++;
                }
                else if (input == "s" && currentCol >= 0 && currentCol < field.GetLength(1) && currentRow >= 0 && currentRow + 1 < field.GetLength(0))
                {
                    if (field[currentRow + 1, currentCol] == 'F')
                    {
                        isAtFinal = true;
                    }

                    field[currentRow, currentCol] = '.';
                    field[currentRow + 1, currentCol] = 'S';
                    madeMoves++;
                }
                else if (input == "d" && currentCol >= 0 && currentCol + 1 < field.GetLength(1) && currentRow >= 0 && currentRow < field.GetLength(0))
                {
                    if (field[currentRow, currentCol + 1] == 'F')
                    {
                        isAtFinal = true;
                    }

                    field[currentRow, currentCol] = '.';
                    field[currentRow, currentCol + 1] = 'S';
                    madeMoves++;
                }
                else if (input == "w" && currentCol >= 0 && currentCol < field.GetLength(1) && currentRow - 1 >= 0 && currentRow < field.GetLength(0))
                {
                    if (field[currentRow - 1, currentCol] == 'F')
                    {
                        isAtFinal = true;
                    }

                    field[currentRow, currentCol] = '.';
                    field[currentRow - 1, currentCol] = 'S';
                    madeMoves++;
                }

                Console.Clear();

                if (isAtFinal)
                {
                    Console.WriteLine($"Moves made to the final: {madeMoves}");
                    break;
                }
            }
        }
    }
}