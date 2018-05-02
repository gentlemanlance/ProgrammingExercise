using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExercises
{
    class Son1 : Parent
    {
        public override void grow()
        {
            base.y++;
            base.z++;
            base.grow();
        }

    }
}
