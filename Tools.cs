using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace where_we_meet
{
    class Tools
    {
        public static int distanseFromHouse(int numberOfHouse, House[] houses)
        {
            int distance = 0;
            House carrentHouse = houses[numberOfHouse];
            for (int i = 0; i < houses.Length; i++)
            {
                distance += (Math.Abs(carrentHouse.X - houses[i].X)) +( Math.Abs(carrentHouse.Y - houses[i].Y));
                
            }

            return distance;
        }

        public static int getMinOrDistance(int min, int numberOfHouse, House[] houses)
        {
            int distance = 0;
            House carrentHouse = houses[numberOfHouse];
            for (int i = 0; i < houses.Length; i++)
            {
                distance += (Math.Abs(carrentHouse.X - houses[i].X)) + (Math.Abs(carrentHouse.Y - houses[i].Y));
                if (distance > min)
                {
                    return min;
                }
            }
            return distance;          
        }

    }
}
