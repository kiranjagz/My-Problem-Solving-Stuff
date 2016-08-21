using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Kiran
    {

        public interface IBird
        {
            Egg Lay();
        }

        // Should implement IBird
        public class Chicken : IBird
        {
            private Egg egg;

            public Chicken()
            {

            }

            public Chicken(Egg _egg)
            {

            }

            public Egg Lay()
            {
                throw new NotImplementedException();
            }
        }

        public class Egg
        {
            public Egg(Func<IBird> createBird)
            {
                throw new NotImplementedException("Waiting to be implemented.");
            }

            public IBird Hatch()
            {
                throw new NotImplementedException("Waiting to be implemented.");
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                //      var chicken1 = new Chicken();
                //      var egg = chicken1.Lay();
                //      var childChicken = egg.Hatch();
            }
        }
    }
}
