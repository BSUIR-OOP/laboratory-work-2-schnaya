using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Ellipse : Line
    {
        public int height;
       
        public int Height{
            set
            {
                string fcoordinate = Microsoft.VisualBasic.Interaction.InputBox("Введите высоту");
                height = Int32.Parse(fcoordinate);
              
            }
            get => height;

        }
        public int width;
        public int Width
        {
            set
            {
                string fcoordinate = Microsoft.VisualBasic.Interaction.InputBox("Введите ширину");
                width = Int32.Parse(fcoordinate);

            }
            get => width;

        }
    }
}
