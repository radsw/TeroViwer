using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace NavigatorTero
{
        public class BorderedGroupBox : GroupBox
        { 
        private Color _borderColor = Color.Black;
        private int _borderWidth = 2;
        private int _borderRadius = 5;
        private int _textIndent = 10;

        public BorderedGroupBox() : base()
        {

        }

        public BorderedGroupBox(int width, float radius, Color color) : base()
        {

        }

        public Color BorderColor
        {

        }

        public int BorderWidth
        {

        }

        public int BorderRadius
        {

        }

        public int LabelIndent
        {
}
        }

        private void BorderedGroupBox_Paint(object sender, PaintEventArgs e) =>
            DrawGroupBox(e.Graphics);

        private void DrawGroupBox() =>
            this.DrawGroupBox(this.CreateGraphics());

        private void DrawGroupBox(Graphics g)
        {

        }

        protected override void Dispose(bool disposing)
        {
        }

        private void InitializeComponent() => components = new System.ComponentModel.Container();
    }
}