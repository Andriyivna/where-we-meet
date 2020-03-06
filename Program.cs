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
            
            int m;
            m = Convert.ToInt32(Console.ReadLine());
            for(int j = 0; j < m; j++)
            {
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                House[]houses = new House[n];

                for (int i = 0; i < n; i++)
                {
                    string line = Console.ReadLine();
                    string[] numbers = line.Split(' ');
                    houses[i].X = Convert.ToInt32(numbers[0]);
                    houses[i].Y = Convert.ToInt32(numbers[1]);
                }


                // variant 1 (linear)
                //int min = Tools.distanseFromHouse(0, houses);
                //for (int i = 1; i < houses.Length; i++)
                //{
                //    min = Tools.getMinOrDistance(min, i, houses);
                //}


                // variant 1.1 (linear)
                for (int i = 0; i < houses.Length; i++)
                {
                    for (int c = i; c < houses.Length; c++)
                    {
                        int distanceBetween = (Math.Abs(houses[c].X - houses[i].X)) + (Math.Abs(houses[c].Y - houses[i].Y));
                        houses[c].dist += distanceBetween;
                        houses[i].dist += distanceBetween;
                    }
                }
                int min = houses[0].dist;
                for (int i = 1; i < houses.Length; i++)
                {
                    min = Math.Min(min, houses[i].dist);
                }


                // variant 2 (parallel)
                //Parallel.For(0, n, i => {
                //    houses[i].dist = Tools.distanseFromHouse(i, houses);
                //});
                //int min = houses[0].dist;
                //for (int i = 1; i < houses.Length; i++)
                //{
                //    min = Math.Min(min, houses[i].dist);
                //}


                Console.WriteLine(min);

               
            }
           
           
        }
    }
}
