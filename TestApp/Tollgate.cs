using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    /// <summary>
    /// Cars enter a tollgate, as in a first in first out concept
    /// </summary>
    public class Tollgate
    {
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
    }
}
