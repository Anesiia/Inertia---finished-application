using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inertia_.ElementsOfField
{
    public abstract class Element
    {
        public int X;
        public int Y;

        protected Element(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
