using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    class Line
    {

         public Point finish;
        public Point start;
        public Point Start
        {
            set
            {
                string fcoordinate = Microsoft.VisualBasic.Interaction.InputBox("Введите координаты точки через пробел:");
                string[] coord = fcoordinate.Split(' ');
                int[] x = new int[2];
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = Int32.Parse(coord[i]);
                }

                Point p1 = new Point(x[0], x[1]);
                start = p1;
            }
            get => start;
        }
        public Point Finish
        {
            set
            {
                string fcoordinate = Microsoft.VisualBasic.Interaction.InputBox("Введите координаты точки через пробел:");
                string[] coord = fcoordinate.Split(' ');
                int[] x = new int[2];
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = Int32.Parse(coord[i]);
                }

                Point p1 = new Point(x[0], x[1]);
                finish = p1;
            }
            get => finish;
        }


    }

}

