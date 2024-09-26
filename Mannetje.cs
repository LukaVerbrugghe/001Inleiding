using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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

            //voor de torso hebben we een rechthoek nodig
            //poging: 3
            int startPositieLichaamX = (xPositieCirkel) + (sizeHead / 6);
            int startPositieLichaamY = yPositieCirkel + sizeHead;
            int breedteTorso = sizeHead * 2 / 3;
            int lengteTorso = sizeHead * 2;
            g.FillRectangle(brush, startPositieLichaamX, startPositieLichaamY, breedteTorso, lengteTorso);
        }
    }
}
