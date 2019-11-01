using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace where_we_meet
{
    struct House
    {
        public int X;
        public int Y;
        public int dist;
	}        
    
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int m;
            m = Convert.ToInt32(Console.ReadLine());
            for(int j = 0; j < m; j++)
            {
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                House[]houses = new  House[n];

                for (int i = 0; i < n; i++)
                {
                    string line = Console.ReadLine();
                    string[] numbers = line.Split(' ');
                    houses[i].X = Convert.ToInt32(numbers[0]);
                    houses[i].Y = Convert.ToInt32(numbers[1]);
                }
            
            //for ( int i = 1; i < houses.Length; i++)
            //{
            //    min = Tools.getMinOrDistance(min, i, houses);
            //}

            Parallel.For(0, n, i =>
                {
                    houses[i].dist = Tools.distanseFromHouse(i, houses);
                });

                int min = houses[0].dist;
                for (int i = 1; i < houses.Length; i++)
                {
                    min = Math.Min(min, houses[i].dist);
                }

                Console.WriteLine(min);
            }
            watch.Stop();
            Console.WriteLine("time= " + watch.ElapsedMilliseconds);

        

        }
    }
}
