using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CreateClassObject
{
    class Rectangle
    {
        private int height;
        private int width;
        private int area;

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public int Area 
        {
            get
            {
                area = height * width;
                return area;
            }

            set 
            {
                area = value;
            }
        }
    }
}
