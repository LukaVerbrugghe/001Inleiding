using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Inleiding
{
    public class Cirkel
    {
        //de cirkel tekenen we met een elips, deze vraagt een x en y waarde als startpunt en een hoogte en breedte. Die laatste 2 zijn bij een cirkel hetzelfde. We voegen deze samen in straal
        public Graphics g {  get; set; }
        public int xAs {  get; set; }

        public int yAs { get; set; }

        public int straalLengte { get; set; }

        //constructor
        public Cirkel(Graphics graphics, int x, int y, int straal)
        {
            //hier volgende les verder werken aub
            g = graphics;
            xAs = x;
            yAs = y;
            straalLengte = straal;

            drawCircles();
        }

        //cirkel tekenen
        private void drawCircles()
        {
            //brush van willekeurige kleur aanmaken
            Random random = new Random();
            SolidBrush brush = new SolidBrush(Color.FromArgb(random.Next(1, 250), random.Next(1, 250), random.Next(1, 250)));

            //teken de  3 horizontale cirkels
            int huidigeX = xAs - straalLengte;
            int huidigeY = yAs - straalLengte;
            for (int i = 0; i < 3; i++)
            {
                g.FillEllipse(brush, huidigeX, huidigeY, straalLengte, straalLengte);
                huidigeX += straalLengte;
            }

            //teken de onderste 2 cirkels
            huidigeY -= straalLengte;
            for (int i = 0; i < 2; i++)
            {
                g.FillEllipse(brush, xAs, huidigeY, straalLengte, straalLengte);
                huidigeY += straalLengte * 2;
            }
        }
    }
}
