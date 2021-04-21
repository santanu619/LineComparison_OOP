using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison_OOP
{
    class CartesianPoints
    {
        public int x_point1;
        public int x_point2;
        public int y_point1;
        public int y_point2;
        public float length;

        public CartesianPoints(int x_point1, int x_point2, int y_point1, int y_point2)
        {
            this.x_point1 = x_point1;
            this.x_point2 = x_point2;
            this.y_point1 = y_point1;
            this.y_point2 = y_point2;
            this.length = 0;
        }

        public void setTotalEmpWage(float length)
        {
            this.length = length;
        }

        internal void setCartesianPoints(int v)
        {
            throw new NotImplementedException();
        }
    }
}
