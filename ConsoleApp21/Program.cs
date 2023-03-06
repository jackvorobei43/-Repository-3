using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача1
            //Console.WriteLine("Введите число элементов массива ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] x = new int[n];
            //Random Rand = new Random(); 
            //for (int i=0; i<n; i++)
            //{
            //    x[i] = Rand.Next(1, 80);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"x[{i}]={x[i]}");
            //}
            //int max = x[0];
            //int min = x[0];
            //int imax = 0;
            //int imin = 0;
            //for (int i = 1; i < n; i++)
            //{
            //    if (x[i] > max)
            //    {
            //        max = x[i];
            //        imax = i;
            //    }
            //     if (x[i] < min)
            //    {
            //        min = x[i];
            //        imin = i;
            //    }
            //}
            //Console.WriteLine($"max={max}");
            //Console.WriteLine($"min={min}");
            //int t = x[imax];
            //x[imax] = x[imin];
            //x[imin] = t;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"x[{i}]={x[i]}");
            //}
            //Console.ReadKey();

            //Задача2
            //double [] x = new double [12];
            //for (int i = 0; i < 12; i++)
            //{
            //    x[i] = Convert.ToDouble(Console.ReadLine());

            //}
            //Array.Sort(x);
            //Array.Reverse(x);
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine($"x[{i}]={x[i]}");

            //}
            //double S = x[0]+x[11];
            //Console.WriteLine($"{S:f2}");
            //Console.ReadKey();

            //Задача3
            double[] x = new double[14];
            for (int i = 0; i < 14; i++)
            {
                x[i] = Convert.ToDouble(Console.ReadLine());

            }
            
            for (int i=0;i<6;i++)
            {
                for (int j=i+1; j < 7; j++)
                {
                    if (x[i] > x[j])
                    {
                        double t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            for (int i = 7; i < 13; i++)
            {
                for (int j = i + 1; j < 14; j++)
                {
                    if (x[i] < x[j])
                    {
                        double t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            foreach(double i in x)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();


        }
    }
}
