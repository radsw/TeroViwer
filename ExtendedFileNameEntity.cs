using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatorTero
{
    public class ExtendedFileNameEntity
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public int Xaxis { get; set; } = 0;
        public int Yaxis { get; set; } = 0;
        private bool correct { get; set; } = false;
        public bool Correct { get 
            {
                return correct;
            } } 

        public void convertNameToCoordinates(string text) 
        {

        }

        public static int getNumericalName(string filename) 
        {

        }

        public ExtendedFileNameEntity(string fullPath) 
        {

        }
    }
}
