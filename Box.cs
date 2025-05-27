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

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int getWidth()
        { return width; }
        public int getHeight()
        { return height; }

        public void setWidth(int width)
        {
            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                Console.WriteLine("자연수로 입력해주세요");
            }
        }

        public void setHeight(int height)
        {
            if (height > 0)
            {
                this.height = height;
            }
            else
            {
                Console.WriteLine("자연수로 입력해주세요");
            }
        }

        public int Area()
        {
            return width * height;
        }
    }
}
