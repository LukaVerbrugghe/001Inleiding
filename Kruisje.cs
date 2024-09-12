using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Inleiding
{
    //STAP1: klasse public maken
    public class Kruisje
    {
        //eigenschappen nodig voor het maken van het kruisje
        //startpunt, graphics, breedte en hoogte

        
        public Point StartPoint {  get; set; }

        public Graphics Graphics { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        //constructor
        //welke waarden nodig om in de eigenschappen te steken?
        public Kruisje(Graphics g, int w, int h, Point s) { 
            StartPoint = s;
            Graphics = g;
            Height = h;
            Width = w;

            //kruisje tekenen
            drawCross();
        }

        //kruisje tekenen
        private void drawCross()
        {
            //teken rechtste trapezium
            Point[] pointsA = new Point[4];
            //linksboven (startpunt)
            pointsA[0] = StartPoint;
            //linksboven rechts
            pointsA[1] = new Point(pointsA[0].X + Width, StartPoint.Y);
            //linksonder rechts
            pointsA[2] = new Point(pointsA[0].X - Width, pointsA[0].Y + Height);
            //linksonder links
            pointsA[3] = new Point(pointsA[2].X - Width, pointsA[2].Y);

            //tekenen
            Graphics.FillPolygon(new SolidBrush(Color.Purple), pointsA);

            //teken linkse trapezium
            Point[] pointsB = new Point[4];
            pointsB[0] = new Point(pointsA[3].X, StartPoint.Y);
            pointsB[1] = new Point(pointsA[2].X, StartPoint.Y);
            pointsB[2] = new Point(pointsA[1].X, pointsA[2].Y);
            pointsB[3] = new Point(pointsA[0].X, pointsA[2].Y);

            //tekenen
            Graphics.FillPolygon(new SolidBrush(Color.Purple), pointsB);
        }
    }
}
