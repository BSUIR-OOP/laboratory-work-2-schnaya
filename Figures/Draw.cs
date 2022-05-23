using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2.Figures
{
    class Draw
    {
       public void DrawRect(PaintEventArgs e, List<Point> points)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, points[0].X, points[0].Y, points[1].X, points[0].Y);
            e.Graphics.DrawLine(pen, points[1].X, points[0].Y, points[1].X, points[1].Y);
            e.Graphics.DrawLine(pen, points[1].X, points[1].Y, points[0].X, points[1].Y);
            e.Graphics.DrawLine(pen, points[0].X, points[1].Y, points[0].X, points[0].Y);
        }
    }
}
