using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatorTero
{
    public abstract class AIndexGenerator
    {
        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        public enum MatrixSize
        {
            Four,
            Nine,
            TwentyFive,
            FourtyNine
        };

        /// <summary>
        /// punkt środkowy w całem obszarze mapy.
        /// </summary>
        protected Point middlePoint = new Point(0, 0);

        /// <summary>
        /// graniczne indeksy mapy.
        /// </summary>
        protected Point BorderSizeXY;
    }
}
