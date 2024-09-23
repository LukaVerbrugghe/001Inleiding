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

        public int sizeHead {  get; set; }

        //constructor
        public Mannetje(Graphics graphics, SolidBrush solidBrush, int x, int y, int size) { 
            g = graphics;
            brush = solidBrush;
            xPositieCirkel = x;
            yPositieCirkel = y;
            this.sizeHead = size;

            //we beginnen met een cirkel te tekenen als hoofd
            tekenHoofd();
            tekenTorso();
        }

        private void tekenHoofd()
        {
            g.FillEllipse(brush, xPositieCirkel, yPositieCirkel, sizeHead, sizeHead);
        }

        private void tekenTorso()
        {
            //dit was zware tyfus zooi, niet proberen
            //g.FillRectangle(brush, )
        }
    }
}
