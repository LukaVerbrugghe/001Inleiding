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

        private void btnMeerdereKruisjes_Click(object sender, EventArgs e)
        {
            //meerdere kruisjes tekenen door gebruik te maken van onze klasse
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                Kruisje kruisje = new Kruisje(pnlCanvas.CreateGraphics(), rnd.Next(10, 100), rnd.Next(10, 80), new Point(rnd.Next(50, 500), rnd.Next(50, 350)));
            }
        }

        private void btnLeeg_Click(object sender, EventArgs e)
        {
            //clear pannel
            Graphics g =(pnlCanvas.CreateGraphics());
            g.Clear(Color.White);
        }

        private void btnCirkels_Click(object sender, EventArgs e)
        {
            //graphics, pen, etc.
            Graphics g = (pnlCanvas.CreateGraphics());
            Pen redPen = new Pen(Color.Red, 3);

            //teken cirkel
            //variabele voor beginwaarde x-as
            int x = 50;
            //van links naar rechts, teken 3 cirkels (startpunt op x-as wordt telkens 50 verplaatst)
            for (int i = 0; i < 3; i++)
            {
                g.DrawEllipse(redPen, x, 100, 50, 50);
                x += 50;
            }
            int y = 50;
            //teken de laatste 2 kruisjes (boven en onder), x-as veranderd niet, y-as wel
            for (int i = 0;i < 2; i++)
            {
                g.DrawEllipse(redPen, 100, y, 50, 50);
                g.DrawEllipse(redPen, 100, y, 50, 50);
                y += 100;
            }

        }

        private void btnCirkelsKlasse_Click(object sender, EventArgs e)
        {
            Cirkel cirkel = new Cirkel(pnlCanvas.CreateGraphics(), 200, 200, 25);
        }

        private void btnGroepCirkels_Click(object sender, EventArgs e)
        {
            //we willen 100 cirkels van een willekeurige kleur op een willekeurige plaats met een vaste straal
            //willekeurige kleur doet de klasse
            //wikkekeurige plaats berekenen wij
            //straal is vast --> 25
            int straal = 25;

            //100 keer herhalen
            for (int i = 0; i < 3000; i++)
            {
                //willekeurige locatie bereken
                Random random = new Random();
                //int randomX = random.Next(20, 400);
                //int randomY = random.Next(20, 300);

                //teken de cirkel
                Cirkel cirkel = new Cirkel(pnlCanvas.CreateGraphics(), random.Next(20, 400), random.Next(20, 300), straal);
            }
        }

        private void btnMannetje_Click(object sender, EventArgs e)
        {
            //we willen een ventje tekenen
            //dit ventje is eigenlijk een paar vreemde trapezia en een cirkel als hoofd. Helaas kunnen we enkel de trapezia uit een reeds gemaakte klasse maken want de cirkels zijn met te veel en niet de juiste kleur
            //deze cirkel tekenen we dus zelf
            
            //we beginnen direct in een klasse, want daar wordt daan blij van :)
            Mannetje mannetje = new Mannetje(pnlCanvas.CreateGraphics(), new SolidBrush(Color.Red), 25, 25, 30);
        }

        private void btnVeelMannekes_Click(object sender, EventArgs e)
        {

        }

        private void btnMannekesOverload_Click(object sender, EventArgs e)
        {

        }
    }
}
