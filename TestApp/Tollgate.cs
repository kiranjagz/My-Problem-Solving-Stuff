using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Tollgate
    {
        public List<string> Toll = new List<string>();
        public Dictionary<int, string> tollCars = new Dictionary<int, string>();
        int countEnter = 0;
        int CountExit = 0;

        public void Enter(string licensePlate)
        {
            tollCars.Add(countEnter++, licensePlate);
        }

        public string Exit()
        {
            string car = null;

            tollCars.TryGetValue(CountExit, out car);

            if (car == null)
            {
                tollCars.Remove(CountExit);
                CountExit++;
                return car;
            }
            else
                return null;
        }



        //if (car == null)
        //{
        //    return null;
        //}
        //else
        //{           
        // CountExit++;
        // return car;
        //}

    }
}
