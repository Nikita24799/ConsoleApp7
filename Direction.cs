using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Direction 
    {
        internal static ConsoleApp7.Direction LEFT;

        public static ConsoleApp7.Direction RIGHT { get; internal set; }
        public static ConsoleApp7.Direction DOWN { get; internal set; }
        public static ConsoleApp7.Direction UP { get; internal set; }

        private enum Directio
        {
            LEFT,
            RIGHT,
            UP,
            DOWN
        }
    }
}
