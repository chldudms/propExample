using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Box
    {
        private int width;
        private int height;

        public int Width
        { get { return width; }
            set
            {
                if (value > 0)
                {
                    Console.WriteLine("너비는 자연수로 입력해주세요");
                }
                else
                {
                    Width = value;
                }
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    Console.WriteLine("높이는 자연수로 입력해주세요");
                }
                else
                {
                    Height = value;
                }
            }
        }

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        private int area;

        public int Area
        {
            get { return Width * Height; }
     
        }

      
    }
}
