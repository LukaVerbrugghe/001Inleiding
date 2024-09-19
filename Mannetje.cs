using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Inleiding
{
    public class Mannetje
    {
        //alle waardes vd klasse
        public Graphics g {  get; set; }

        public SolidBrush brush { get; set; }

        public int xPositieCirkel {  get; set; }

        public int yPositieCirkel { get; set;}

        public int straalHoofd {  get; set; }

        //constructor
        public Mannetje(Graphics graphics, SolidBrush solidBrush, int x, int y, int straal) { 
            g = graphics;
            brush = solidBrush;
            xPositieCirkel = x;
            yPositieCirkel = y;
            straalHoofd = straal;

            //we beginnen met een cirkel te tekenen als hoofd
            tekenHoofd();
            tekenTorso();
        }

        private void tekenHoofd()
        {
            g.FillEllipse(brush, xPositieCirkel, yPositieCirkel, straalHoofd, straalHoofd);
        }

        private void tekenTorso()
        {
            g.FillRectangle(brush, xPositieCirkel - (straalHoofd * 1/3), yPositieCirkel - straalHoofd, straalHoofd * 2/3, straalHoofd * 2);
        }
    }
}
