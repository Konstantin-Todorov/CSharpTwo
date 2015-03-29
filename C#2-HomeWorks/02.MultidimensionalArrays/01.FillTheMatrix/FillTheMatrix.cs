//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
//a)	
//1	 5	9	13
//2	 6	10	14
//3	 7	11	15
//4	 8	12	16
//b)
//1	 8	9	16
//2	 7	10	15
//3	 6	11	14
//4	 5	12	13
//c)
//7	 11	14	16
//4	 8	12	15
//2	 5	9	13
//1	 3	6	10
//d)
//1	 12	11	10
//2	 13	16	9
//3	 14	15	8
//4	 5	6	7
using System;
class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter the number of rows and coloumns of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int digit = 1;

        // A)
        //1	 5	9	13
        //2	 6	10	14
        //3	 7	11	15
        //4	 8	12	16
        Console.WriteLine("A)");
        for ( int col = 0; col < n; col++)       //Filling the matrix
        {
            for (int row = 0; row < n; row++)
            {
                matrix[col, row] = digit;
                digit++;
            }
        }
        

        for (int col = 0; col < n; col++)           //Printing
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        // B
        //1	 8	9	16
        //2	 7	10	15
        //3	 6	11	14
        //4	 5	12	13
        Console.WriteLine("B)");
        for (int col = 0; col < n; col++)       //Filling the matrix
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = digit;
                    digit++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[col, row] = digit;
                    digit++;
                }
            }
        }

        for (int col = 0; col < n; col++)           //Printing
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        // C
        //7	 11	14	16
        //4	 8	12	15
        //2	 5	9	13
        //1	 3	6	10
        Console.WriteLine("C)");
        int Row = n - 1;
        int Col = 0;
        int startRow = n - 1;
        int startCol = 0;

        while (digit < n * n)
        {
            if (Row == (n - 1) && Col < (n - 1))        //Filling matrix
            {
                if (digit == 1)
                {
                    matrix[Col, Row] = digit;
                }
                startRow--;
                startCol = 0;
                Row = startRow;
                Col = startCol;
                digit++;
                matrix[Col, Row] = digit;

                while (Row < (n - 1) && Col < (n - 1))
                {
                    Row++;
                    Col++;
                    digit++;
                    matrix[Col, Row] = digit;
                }
            }
            if (Row <= (n - 1) && Col == (n - 1))
            {
                startRow = 0;
                startCol++;
                Row = startRow;
                Col = startCol;
                digit++;
                matrix[Col, Row] = digit;

                while (Col < (n - 1))
                {
                    Col++;
                    Row++;
                    digit++;
                    matrix[Col, Row] = digit;
                }
            }
        }
        for (int c = 0; c < n; c++)           //Printing
        {
            for (int r = 0; r < n; r++)
            {
                Console.Write("{0, 4}", matrix[r, c]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        // D
        //1	 12	 11	 10
        //2	 13	 16	 9
        //3	 14	 15	 8
        //4	 5	 6	 7
        Console.WriteLine("D)");
        int offset = 0;
        int ROW = 0;
        int COL = 0;
        while (digit <= n * n)            //Filling matrix
        {
            for (ROW = offset; ROW < n - offset; ROW++)
            {
                COL = offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (COL = 1 + offset; COL < n - offset; COL++)
            {
                ROW = n - 1 - offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (ROW = n - 2 - offset; ROW >= offset; ROW--)
            {
                COL = n - 1 - offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (COL = n - 2 - offset; COL >= offset + 1; COL--)
            {
                ROW = offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            offset++;
        }

        for (int irow = 0; irow < n; irow++)           //Printing
        {
            for (int column = 0; column < n; column++)
            {
                Console.Write("{0, 4}", matrix[irow, column]);
            }
            Console.WriteLine();
        }
    }
}
