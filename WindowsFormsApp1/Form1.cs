using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
             
            InitializeComponent();
           
        }
        public static Point[] Readdata() {
            string fcoordinate = Microsoft.VisualBasic.Interaction.InputBox("Введите координаты первой точки через пробел:");
            string[] coord = fcoordinate.Split(' ');
            int[] x = new int[2];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Int32.Parse(coord[i]);
            }
            string scoordinate = Microsoft.VisualBasic.Interaction.InputBox("Введите координаты ширину и высоту через пробел:");
            coord = scoordinate.Split(' ');
            int[] y = new int[2];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = Int32.Parse(coord[i]);
            }
            Point p1 = new Point(x[0], x[1]);
            Point p2 = new Point(y[0], y[1]);
            Point[] res = { p1, p2 };
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           Line l = new Line();
            Point[] readen = Readdata();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);          
            l.start = readen[0];
            l.finish = readen[1];
            g.DrawLine(myWind, l.start, l.finish);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            Point[] readen = Readdata();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            ellipse.start = readen[0];
            ellipse.width = readen[1].X;
            ellipse.height = readen[1].Y;
            g.DrawEllipse(myWind, ellipse.start.X, ellipse.start.Y, ellipse.width, ellipse.height);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.FromArgb(224, 224, 224));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle();
            Point[] readen = Readdata();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            rec.start = readen[0];
            rec.width = readen[1].X;
            rec.height = readen[1].Y;
            g.DrawRectangle(myWind, rec.start.X, rec.start.Y, rec.width, rec.height);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           parallelogram par = new parallelogram();
            Point[] readen = Readdata();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            par.start = readen[0];
            par.width = readen[1].X;
            par.height = readen[1].Y;
            Point p1 = new Point(readen[0].X+ 50, readen[0].Y);// первая точка
            Point p2 = new Point(readen[0].X + readen[1].X + 50, readen[0].Y);      
            Point p3 = new Point(readen[0].X + readen[1].X, readen[0].Y+ readen[1].Y);// вторая точ
            Point p4 = new Point(readen[0].X, readen[0].Y + readen[1].Y);
            PointF[] points = new PointF[]{p1,p2,p3,p4};
            g.DrawPolygon(myWind, points);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trapezoid trapez = new Trapezoid();
            Point[] readen = Readdata();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            trapez.start = readen[0];
            trapez.width = readen[1].X;
            trapez.height = readen[1].Y;
            
            Point p1 = new Point(readen[0].X + readen[1].X / 3, readen[0].Y);
            Point p2 = new Point(readen[0].X + readen[1].X / 2 + readen[1].X / 3, readen[0].Y);
            Point p3 = new Point(readen[0].X + readen[1].X / 2+ (readen[1].X / 3)*2, readen[0].Y + readen[1].Y);
            Point p4 = new Point(readen[0].X, readen[0].Y + readen[1].Y);
            PointF[] points = new PointF[] { p1, p2, p3, p4 };
            g.DrawPolygon(myWind, points);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Triangle tri = new Triangle();
            Point[] readen = Readdata();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            tri.start = readen[0];
            tri.width = readen[1].X;
            tri.height = readen[1].Y;

            Point p1 = tri.start;
            Point p2 = new Point(tri.start.X+tri.width/2, tri.start.Y+tri.height);
            Point p4 = new Point(tri.start.X - tri.width / 2, readen[0].Y + readen[1].Y);
            PointF[] points = new PointF[] { p1, p2, p4 };
            g.DrawPolygon(myWind, points);
        }
    }
}
