using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class MatrixHandling
    {

        public static void LargestInMatrix(int[,] array)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] > max)
                        max = array[i, j];
                }
            }
            Console.WriteLine("The Largest number in the matrix is:  " + max);
        }

        //Smallest in matrix
        public static void SmallestInMatrix(int[,] array)
        {
            int min = 100;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] < min)
                        min = array[i, j];
                }
            }
            Console.WriteLine("The Smallest number in the matrix is:  " + min);
        }
        //Average of all numbers in matrix
        public static void AverageInMatrix(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            float average = (float)sum / (array.GetLength(0) * array.GetLength(1));
            Console.WriteLine("Average of all the numbers in the matrix is:  " + average);
        }

        //Largest in Row/Column
        public static void LargestOfALine(int[,] array, int flag)
        {
            //int max;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int max = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                }
                if (flag == 0)
                {
                    Console.WriteLine("Column " + i + " :  " + max);
                }
                else
                {
                    Console.WriteLine("Row " + i + " :  " + max);
                }

            }
        }
        //Smallest in Row/Column
        public static void SmallestOfALine(int[,] array, int flag)
        {
            //int min;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = 100;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                        min = array[i, j];
                }
                if (flag == 0)
                {
                    Console.WriteLine("Column " + i + " :  " + min);
                }
                else
                {
                    Console.WriteLine("Row " + i + " :  " + min);
                }
            }
        }

        //Average in Row/Column
        public static void AverageInLine(int[,] array, int flag)
        {

            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                int sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum += array[i, j];
                }
                float average = (float)sum / col;
                if (flag == 0)
                {
                    Console.WriteLine("Col  " + i + "  :  " + average);
                }
                else
                {
                    Console.WriteLine("Row  " + i + "  :  " + average);
                }
            }
        }

    }

    class Program : MatrixHandling
    {
        int row = 0, col = 0;
        int[,] array;
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.CreateMatrix();
            MatrixHandling.LargestInMatrix(p.array);
            MatrixHandling.SmallestInMatrix(p.array);
            MatrixHandling.AverageInMatrix(p.array);
            Console.WriteLine("The largest number in each row is:");
            MatrixHandling.LargestOfALine(p.array, 1);
            Console.WriteLine("The smallest number in each row is:");
            MatrixHandling.SmallestOfALine(p.array, 1);
            Console.WriteLine("The average of each row is:");
            MatrixHandling.AverageInLine(p.array, 1);
            int[,] array1 = p.transpose(p.array);
            Console.WriteLine("The largest number in each Column is:");
            MatrixHandling.LargestOfALine(array1, 0);
            Console.WriteLine("The smallest number in each column is:");
            MatrixHandling.SmallestOfALine(array1, 0);
            Console.WriteLine("The average of each Column is:");
            MatrixHandling.AverageInLine(array1, 0);
        }

        //create
        public void CreateMatrix()
        {
            System.Random random = new System.Random();
            Console.WriteLine("Please enter the number of rows in the matrix:");
            this.row = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the number of columns in the matrix:");
            this.col = Convert.ToInt16(Console.ReadLine());
            this.array = new int[row, col];
            Console.WriteLine("The matrix values:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = random.Next(0, 100);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
        public int[,] transpose(int[,] array)
        {
            int w = array.GetLength(0);
            int h = array.GetLength(1);

            int[,] result = new int[h, w];

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    result[j, i] = array[i, j];
                }
            }

            return result;
        }

    }
}