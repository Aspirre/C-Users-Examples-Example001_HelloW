using System;

class Program
{
static int[] v = {6, 3, 93, 1, 36};
        static int g = v.Length - 1;
        static void Main(string[] args) 
        {
            recursion(g);
            Console.ReadKey();
        }
        static void recursion(int x) 
        {
            int n = 0;
            int[] shiftx = new int[5];
            if (x >= 0) 
            {
                shiftx[n] = v[x];
                Console.Write(shiftx[n]);
                n++;
                x--;
            } else 
            {
                return;
            }
            recursion(x);
        }
}