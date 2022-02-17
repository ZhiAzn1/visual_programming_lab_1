using System;
using System.Linq;

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int[] Cash = new int[n];
        for (int i = 0; i < customers.Length; i++)
        {
            Cash[Array.IndexOf(Cash, Cash.Min())] += customers[i];
        }
        return Cash.Max();

    }
}

namespace HomeworkN1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(HW1.QueueTime(new int[] { 5, 4, 3 }, 1));
            Console.WriteLine(HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2));
            Console.WriteLine(HW1.QueueTime(new int[] { 2, 3, 10 }, 2));
        }
    }
}