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
        List<Line> figures = new List<Line>();
        private void button1_Click(object sender, EventArgs e)
        {
            Line l = new Line();         
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            l.Start = new Point();
            l.Finish = new Point();
            figures.Add(l);
            g.DrawLine(myWind, l.start, l.finish);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            ellipse.Start = new Point();
            ellipse.Width = new int();
            ellipse.Height = new int();
            figures.Add(ellipse);
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
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            rec.Start = new Point();
            rec.Width = new int();
            rec.Height = new int();
            figures.Add(rec);
            g.DrawRectangle(myWind, rec.start.X, rec.start.Y, rec.width, rec.height);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Parallelogram par = new Parallelogram();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            par.Start = new Point();
            par.Second = new Point();
            par.Third = new Point();
            par.Finish = new Point();
            figures.Add(par);
            PointF[] points = new PointF[]{par.Start,par.Second,par.Third,par.Finish};
            g.DrawPolygon(myWind, points);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trapezoid trapez = new Trapezoid();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            trapez.Start = new Point();
            trapez.Width = new int();
            trapez.Height =new int();
            figures.Add(trapez);
            Point p1 = new Point(trapez.Start.X + trapez.Width / 3, trapez.Start.Y);
            Point p2 = new Point(trapez.Start.X + trapez.Width / 2 + trapez.Width / 3, trapez.Start.Y);
            Point p3 = new Point(trapez.Start.X + trapez.Width / 2+ (trapez.Width / 3)*2, trapez.Start.Y + trapez.Height);
            Point p4 = new Point(trapez.Start.X, trapez.Start.Y + trapez.Height);
            PointF[] points = new PointF[] { p1, p2, p3, p4 };
            g.DrawPolygon(myWind, points);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Triangle tri = new Triangle();
            Graphics g = pictureBox1.CreateGraphics();
            Pen myWind = new Pen(Color.Black, 2);
            tri.Start = new Point();
            tri.Second =new Point();
            tri.Finish = new Point();
            figures.Add(tri);
            PointF[] points = new PointF[] { tri.Start,tri.Second, tri.Finish};
            g.DrawPolygon(myWind, points);
        }
    }
}
