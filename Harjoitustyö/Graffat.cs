using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Harjoitustyö
{
    class Graffat
    {
        private static Graphics gOsat;

        public Graffat(Graphics g) //gOsat lähteköön liikkeelle täältä
        {
            gOsat = g;
            pohjus();
        }

            public void pohjus()
            {
                Brush tausta = new SolidBrush(Color.White); //Valkonen tausta
                Pen viivat = new Pen(Color.Black); //Mustat viivat

                gOsat.FillRectangle(tausta, new Rectangle(0, 0, 300, 300)); //Tausta

                gOsat.DrawLine(viivat, new Point(100, 0), new Point(100, 300)); //Pystyviiva
                gOsat.DrawLine(viivat, new Point(200, 0), new Point(200, 300)); //Pystyviiva

                gOsat.DrawLine(viivat, new Point(0, 100), new Point(300, 100)); //Vaakaviiva
                gOsat.DrawLine(viivat, new Point(0, 200), new Point(300, 200)); //Vaakaviiva

        } //Pohjaruudukko 300x300 pohjalle (((((TURHA)))))) ehkä?
        public void drawX(Point loc)
        {
            Pen xKyna = new Pen(Color.Black, 5);
            int xAbs = loc.X * 100;
            int yAbs = loc.Y * 100;

            gOsat.DrawLine(xKyna, xAbs, yAbs, xAbs + 100, yAbs + 100);
            gOsat.DrawLine(xKyna, xAbs + 100, yAbs, xAbs, yAbs + 100);
        }
    }
}
