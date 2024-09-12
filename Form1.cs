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
            Pen redPen = new Pen(redBrush, 2);

            //teken cirkel
            g.DrawEllipse(redPen, 50, 100, 100, 100);

            //opgevulde rechthoek (geel)
            g.FillRectangle(new SolidBrush(Color.Yellow), 150, 150, 100, 200);

            //driehoek (3 delige poligon)
            //we zullen points nodig hebben --> array met de punten die we nodig hebben
            Point[] points = new Point[3];
            points[0] = new Point(200, 100);
            points[1] = new Point(160, 175);
            points[2] = new Point(250, 175);

            g.DrawPolygon(redPen, points);

            //trapezuim --> poligon
            Point[] points2 = new Point[4];
            points2[0] = new Point(200, 100);
            points2[1] = new Point(250, 100);
            points2[2] = new Point(300, 200);
            points2[3] = new Point(250, 200);

            //nieuwe groene pen
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Pen greenPen = new Pen(greenBrush, 1);

            g.DrawPolygon(greenPen, points2);

            //diabolo van lijnen (bijzonder)
            Point[] points3 = new Point[2];
            points3[0] = new Point(10, 10);
            points3[1] = new Point(300, 300);
            for (int i = 0; i < 110; i++)
            {
                g.DrawLine(greenPen, points3[1], points3[0]);
                points3[0].X += 3;
                points3[1].X -= 3;
            }

        }

        private void btnKruisje_Click(object sender, EventArgs e)
        {
            //hoe maken we een kruisje? --> 2 trapeziums
            //graphic bepalen
            Graphics g = pnlCanvas.CreateGraphics();

            //trapezuim --> poligon
            Point[] points2 = new Point[4];
            points2[0] = new Point(200, 100);
            points2[1] = new Point(220, 100);
            points2[2] = new Point(180, 200);
            points2[3] = new Point(160, 200);
            g.DrawPolygon(new Pen(new SolidBrush(Color.Red), 1), points2);

            //trapezuim --> poligon
            Point[] points3 = new Point[4];
            points3[0] = new Point(180, 100);
            points3[1] = new Point(160, 100);
            points3[2] = new Point(200, 200);
            points3[3] = new Point(220, 200);
            g.DrawPolygon(new Pen(new SolidBrush(Color.Red), 1), points3);
        }

        private void btnKruisjeClass_Click(object sender, EventArgs e)
        {
            //teken kruisje
            Kruisje kruisje = new Kruisje(pnlCanvas.CreateGraphics(), 60, 100, new Point(190, 100));
        }
    }
}
