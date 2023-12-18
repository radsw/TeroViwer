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
using System.Diagnostics;

namespace NavigatorTero
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //tester();
            afterInitalComponent();
            
        }

        FileLoader fileImageLoader;

        LargeImageController largeImageController;
        IndexGenerator indexGenerator;
        ImageProcessor imageProcessor;
        Image bigImage = null;
        string GroupExtension = "";
        Point maximumSize;
        double zoom = 1;
        bool ParrarelLock=false;

        bool statusBar = true;

        int stepIndex = 9;
        //                       0      1    2    3     4    5      6     7     8   9   10  11 12 13
        double[] ZoomSteps = { 0.005, 0.01, 0.02, 0.05, 0.1, 0.15, 0.20, 0.25, 0.5, 1, 1.5, 2, 3, 4 };

        MapSelector ms = new MapSelector();
        AIndexGenerator.MatrixSize LoadedMatrixSize = AIndexGenerator.MatrixSize.Nine;

        private void LoadSelectedMap(string DirectoryToMap) 
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImageProcessor_imageProcessorError()
        {

        }

        private void setWarningLabel(bool status) 
        {
            
        }

        private AIndexGenerator.MatrixSize getMatrixSize() 
        {
            
        }


        private void LoadMapsToComboboxes() 
        {
            
        }

        private void uiStatus(bool status) 
        {
           
        }

        private void Processor_wokerKomplitUnion(object sender, EventArgs e)
        {
           
        }

        private void insertBigImageToPictureBox()
        {
          
        }

        private void Processor_wokerKomplitZoom(object sender, EventArgs e)
        {
            
        }

        private void MoveWholeMap(IndexGenerator.Direction direction, int moveStep) 
        {
            
        }

        private void toolStripPowiekszenie_Click(object sender, EventArgs e)
        {

        }


        private void toolStripZmniejszenie_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void opcjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void opcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void utwórzListęMapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMapCollector_OnClosingLoadData(object sender, EventArgs e)
        {
        }

        private void ukryjPasekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void attachEventToolStrip()
        {

        }

        private void toolStripComboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBoxMapy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
