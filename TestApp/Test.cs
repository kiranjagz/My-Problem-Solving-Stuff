using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Test
    {
        public class Egg
        {
            private IBird chicken;

            public Egg(IBird createBird)
            {
                createBird = chicken();
            }

            public IBird Hatch()
            {
                return chicken.Lay();
            }
        }


        public interface IBird
        {
            Egg Lay();
        }
        // Should implement IBird
        public class Chicken : IBird
        {
            private Egg egg = new Egg(new Chicken().Lay());

            public Chicken()
            {
            }
            public Egg Lay()
            {
               return (Egg)egg.Hatch();
            }
        }
    }

}
