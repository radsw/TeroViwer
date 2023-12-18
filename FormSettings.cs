using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigatorTero
{
    public partial class FormSettings : Form
    {
        public static Color[] avaiableColors = 
		{
        }; 

        public Color s_backgroundcolor
        {
            get;
            set;
        } = Color.LightGray;

        public bool s_nightMode { get; set; }

        public FormSettings()
        {
        }


        private string colorToString(Color color) 
        {

        }

        private Color stringToColor(string nazwakoloru)
        {

        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        public void ChangeBackground() 
        {

        }

        public void LoadSettingsToMemory() 
        {

        }

        public void SaveSettingToConfig() 
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKolory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
