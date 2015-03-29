using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class KukataIsDancing
{
    public static int[] directionX = { 1, 0, -1, 0 };
    public static int[] directionY = { 0, -1, 0, 1 };

    static void Main()
    {
        int dancingMoves = int.Parse(Console.ReadLine());
        for (int i = 0; i < dancingMoves; i++)
        {
            string movement = Console.ReadLine();
            int finalPosition = FinalPosition(movement);
            PrintResult(finalPosition);
        }
    }

    public static void PrintResult(int result)
    {
        if (result == 0)
        {
            Console.WriteLine("BLUE");
        }
        else if (result == 1)
        {
            Console.WriteLine("RED");
        }
        else
        {
            Console.WriteLine("GREEN");
        }
    }

    public static int FinalPosition(string movement)
    {
        int[,] cube = new int[3, 3];
        cube[0, 0] = cube[0, 2] = cube[2, 0] = cube[2, 2] = 1;
        cube[1, 1] = 2;

        int row = 1;
        int col = 1;
        int directionIndex = 0;
        for (int i = 0; i < movement.Length; i++)
        {
            char currentMove = movement[i];
            if (currentMove == 'L')
            {
                directionIndex++;
                directionIndex = (directionIndex == 4) ? 0 : directionIndex;
            }
            else if (currentMove == 'R')
            {
                directionIndex--;
                directionIndex = (directionIndex == -1) ? 3 : directionIndex;
            }
            else
            {
                row += directionX[directionIndex];
                col += directionY[directionIndex];
                if (row == -1)
                {
                    row = 2;
                }
                if (row == 3)
                {
                    row = 0;
                }
                if (col == -1)
                {
                    col = 2;
                }
                if (col == 3)
                {
                    col = 0;
                }
            }
        }
        return cube[row, col];
    }
}
