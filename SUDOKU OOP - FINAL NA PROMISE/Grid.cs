using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUDOKU_OOP___FINAL_NA_PROMISE
{
    internal class Grid
    {
        
        public Space[,] Board { get; private set; }
        private int SIZE = 9;

        public Grid()
        {
            Board = new Space[SIZE, SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Board[i, j] = new Space();
                }
            }
        }

        public void Initialize()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Board[i, j].Value = 0;
                    Board[i, j].Fixed = false;
                  
                }
            }

           
        }
        

        private bool BoardChecker(Grid sudoku, int row, int col, int num)
        {
            for (int i = 0; i < SIZE; i++)
            {
                if (sudoku.Board[row, i].Value == num || sudoku.Board[i, col].Value == num)
                {
                    return false;
                }
            }   

            int startRow = row - row % 3;          
            int startCol = col - col % 3;                    

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (sudoku.Board[startRow + i, startCol + j].Value == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

       public bool GenerateGrid(Grid sudoku)
        {
            Random rand = new Random();

            for (int row = 0; row < SIZE; row++)
            {
                for (int col = 0; col < SIZE; col++)
                {

                    int[] numbers = new int[SIZE];
                    for (int i = 0; i < SIZE; i++)
                        numbers[i] = i + 1; //1 to 9



                    for (int i = SIZE - 1; i > 0; i--)
                    {
                        int j = rand.Next(i + 1);     
                       // (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
                        int temp = numbers[i];                   //temp = 1
                        numbers[i] = numbers[j];                   // 1 = 5                                                              
                        numbers[j] = temp;                        // 5 = 5
                    }

                    bool placed = false;
                    foreach (int num in numbers) // array 1 to 9 
                    {                            // 4,0       7
                        if (BoardChecker(sudoku, row, col, num))
                        {
                            sudoku.Board[row, col].Value = num;
                            placed = true;
                            break;
                        }
                    }

                    if (!placed)
                    {
                        return false;
                    }
                }
            }

            return true;
       }

        public void DisplayGrid(Grid sudoku)
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                   
                    Console.Write(sudoku.Board[i, j].Value + " \t");
                   
                }
                Console.WriteLine("");
            }
         
        }
    }
}
