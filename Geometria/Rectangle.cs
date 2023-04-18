using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    public class Rectangle
    {
        private int xDimension;
        private int yDimension;
        private int area;
        private int perimeter;
        private int setArea(int xDimension, int yDimension)
        {
            return xDimension * yDimension;
        }

        private int setPerimeter(int xDimension, int yDimension)
        {
            return (xDimension * 2) + (yDimension * 2);
        }

        public Rectangle(int xDimension, int yDimension)
        {
            this.xDimension = xDimension;
            this.yDimension = yDimension;   
            this.area = setArea(xDimension, yDimension);
            this.perimeter = setPerimeter(xDimension,yDimension);
        }
        public int getArea()
        {
            return this.area;
        }

        public int getPerimeter()
        {
            return this.perimeter;
        }

        public int getxDimension()
        {
            return this.xDimension;
        }

        public int getyDimension()
        {
            return this.yDimension;
        }
    }
}
