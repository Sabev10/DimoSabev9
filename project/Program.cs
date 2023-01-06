using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n+1];

            int min = mass[0];

            for (int i = 0; i < n; i++) {
                if (mass[i] < min) {
                    mass[i] = min;
                }
            }
            Console.WriteLine(min);

            
        }
    }
}
