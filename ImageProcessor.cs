using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigatorTero
{
    public delegate void WokrerCompleteZoom(object sender, EventArgs e);
    public delegate void WokrerCompleteUnion(object sender, EventArgs e);
    public delegate void ImageProcessorError();

    public class ImageProcessor
    {
        readonly BackgroundWorker worker = new BackgroundWorker();

        private bool locking = false;

        private double zoom = 1;
        private Point sourceDimension = Point.Empty;

        private Image g_renderedImage = null;
        private Image g_returnedImage = null;

        public ImageProcessor(){}

        public void runUnionImage(Dictionary<Point, Image> loadedImages)
        {

        }

        public bool checkEqualSize(Dictionary<Point,Image> images) 
        {

        }

        private void Worker_DoWorkUnionImage(object sender, DoWorkEventArgs e)
        {

        }

        public void runZoomImage()
        {

        }

        private Bitmap ZoomImage(Image sourceImage, Point newSizeXY)
        {
        }

        private void Worker_DoWorkZoomImage(object sender, DoWorkEventArgs e)
        {

        }

        private void Worker_CompletedUnion(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void Worker_CompletedZoom(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        public void setZoom(double val) { zoom = val; }

        public static Point countNewDimensions(Point currentImageSize, double zoom) 
        {

        }

        public Image getImage() 
        {

        }

        private void unionImage(Dictionary<Point, Image> imagi,double scale = 1) 
        {

        }
    }
}
