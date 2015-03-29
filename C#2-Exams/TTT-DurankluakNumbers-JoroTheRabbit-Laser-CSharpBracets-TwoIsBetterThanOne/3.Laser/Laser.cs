using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Laser
{
    static void Main()
    {
        int[] dims = GetThreeNumbersFromConsole();
        int[] pos = GetThreeNumbersFromConsole();
        int[] vect = GetThreeNumbersFromConsole();
        bool[, ,] visited = new bool [dims[0]+1 , dims[1] + 1, dims[2] + 1];
        while (true)
        {
            visited[pos[0], pos[1], pos[2]] = true;
            int[] newPos = new int[3];
            for (int i = 0; i < 3; i++)
            {
                newPos[i] = pos[i] + vect[i];
            }
            if (visited[newPos[0], newPos[1], newPos[2]] || HowManyIndexesAreLimit(newPos, dims) >= 2 )
            {
                Console.WriteLine("{0} {1} {2}",pos[0],pos[1],pos[2]);
                return;
            }
            if (HowManyIndexesAreLimit(newPos, dims) == 1) 
            {
                ReverseComponent(newPos,vect, dims);
            }
            for (int i = 0; i < 3; i++)
            {
                pos[i] = newPos[i];
            }
        }
    }

    private static void ReverseComponent(int[] newPos,int[] vect, int[] dims)
    {
        for (int i = 0; i < 3; i++)
        {
            if (newPos[i] == 1 && vect[i] == -1)
            {
                vect[i] *= -1;
            }
            else if (newPos[i] == dims[i] && vect[i] == 1)
            {
                vect[i] *= -1;
            }
            {

            }
        }
    }
    static int HowManyIndexesAreLimit(int[] pos,int[] dim)
    {
        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            if (pos[i] == 1 || pos[i] == dim[i])
            {
                count++;
            }
        }
        return count;
    }
    static int[] GetThreeNumbersFromConsole()
    {
        string input = Console.ReadLine();
        string[] splitted = input.Split(' ');
        return splitted.Select(x => int.Parse(x)).ToArray();
    }
}
