using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigatorTero
{
    public partial class FormDownloadErrorImage : Form
    {
        FileLoader fi = new FileLoader();
        ImageSaver imageSaver = new ImageSaver();
        Dictionary<string, string> totalFragmentsToSave = new Dictionary<string, string>();
        Dictionary<string, string> FilesCannotSaved = new Dictionary<string, string>();
        Dictionary<string, string> FilesErrors = new Dictionary<string, string>();

        public FormDownloadErrorImage()
        {
            InitializeComponent();
        }

        private string FilePah="";

        private string WhereToSave = Environment.CurrentDirectory + "\\" + WarningAndStrings.directory_other_fragments;
        bool bglock = false;

        private void buttonAccept_Click(object sender, EventArgs e)
        {

        }

        private void statusUI(bool sts) 
        {

        }

        private void Bg1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void Bg1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
