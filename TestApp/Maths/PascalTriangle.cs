using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Maths
{
    public class PascalTriangle
    {
        public int IsPascalTriangle(int col, int row)
        {
            if (col == 0)
            {
                return 1;
            }
            return (row * IsPascalTriangle(col - 1, row - 1)) / col;
        }
    }
}
