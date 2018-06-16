using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum2
{
    static class Accauntant
    {
        public static bool AskFoorBonus(Post worker, int hours)
        {
            if (hours >= (int)worker)
                return true;
            return false;
        }
    }
}
