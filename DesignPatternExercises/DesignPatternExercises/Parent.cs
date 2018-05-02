using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExercises
{
    abstract class Parent
    {
        private float x;
        protected int y;
        public int z;

        public virtual void grow()
        {
            x++;
            y++;
            z++;
            Console.WriteLine("{0},{1},{2}", x, y, z);
        }
    }
}
