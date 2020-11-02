using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOOP
{
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();

            this.Color1 = Color.Black;
            this.Color2 = Color.Blue;
        }


       protected string Title
        {
            set
            {
                //logic
                this.label1.Text += value;
            }
        }

        public Color Color1 { get; set; }
        public Color Color2 { get; set; }

        private void FrmLogo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(0, this.ClientRectangle.Height);
            LinearGradientBrush brush1 = new LinearGradientBrush(pt1, pt2, this.Color1, this.Color2);

            g.FillRectangle(brush1, this.ClientRectangle);

        }
    }
}
