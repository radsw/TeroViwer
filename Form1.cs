using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using static NavigatorTero.IndexGenerator;

namespace NavigatorTero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileLoader fileImageLoader;

        LargeImageController largeImageController;
        IndexGenerator indexGenerator;
        ImageProcessor imageProcessor;
        Image bigImage = null;
        string GroupExtension = "";
        Point maximumSize;
        double zoom = 1;
        int stepIndex = 9;
        //                       0      1    2    3     4    5      6     7     8   9   10  11 12 13
        double[] ZoomSteps = { 0.005, 0.01, 0.02, 0.05, 0.1, 0.15, 0.20, 0.25, 0.5, 1, 1.5, 2, 3, 4 };

        MapSelector ms = new MapSelector();
        AIndexGenerator.MatrixSize LoadedMatrixSize = AIndexGenerator.MatrixSize.Nine;

        const int minimumSize4 = 2;
        const int minimumSize9 = 3;
        const int minimumSize25 = 5;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setMatrixSize(AIndexGenerator.MatrixSize size) 
        {

        }

        private void uiStatus(bool status) 
        {

        }

        private void buttonPrawo_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrawo2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLewo_Click(object sender, EventArgs e)
        {

        }

        private void buttonLewo2_Click(object sender, EventArgs e)
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {

        }

        private void buttonUp2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {

        }


    }
}
