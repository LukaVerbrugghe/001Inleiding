using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001Inleiding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZonderKlassen_Click(object sender, EventArgs e)
        {
            //figuren tekenen
            // dit is niet de beste manier, normaal zouden we met klassen werken

            //waar willen we tekekenen --> graphics
            Graphics g = pnlCanvas.CreateGraphics();

            //iets tekenen --> draw
            //iets opvallen --> fill

            //brush nodig om op te kunnen vullen en om de pen te maken
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //pen nodig om te kunnen tekenen
            Pen redPen = new Pen(redBrush, 5);

            //teken cirkel
            g.DrawEllipse(redPen, 50, 100, 100, 100);

            //opgevulde rechthoek (geel)
            g.FillRectangle(new SolidBrush(Color.Yellow), 50, 150, 100, 200);

            //driehoek (3 delige poligon)
            //we zullen points nodig hebben
            Point[] points = new Point[3];
        }
    }
}
