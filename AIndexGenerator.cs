﻿using System;
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

        }

        public enum MatrixSize
        {

        };


        protected Point middlePoint = new Point(0, 0);


        protected Point BorderSizeXY;
    }
}
