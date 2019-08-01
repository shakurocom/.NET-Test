using System;

namespace TG.Exam.Algorithms
{
    class Program
    {
        static int Foo(int a, int b, int c)
        {
            if (1 < c)
                return Foo(b, b + a, c - 1);
            else
                return a;
        }

        static int[] Bar(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Foo result: {0}", Foo(7, 2, 8));
            Console.WriteLine("Bar result: {0}", string.Join(", ", Bar(new[] { 7, 2, 8 })));

            Console.ReadKey();
        }
    }
}
