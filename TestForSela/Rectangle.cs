using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForSela
{
    class Rectangle :Shap
    {

        private double width;
        private double height;

        public double Width { get { return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }

        public Rectangle(double widthUser,double heightUser)
        {
            Name = "Rectangle";
            Width = widthUser;
            Height = heightUser;
            Scope = CalcScope(widthUser, heightUser);
            Area = CalcArea(widthUser, heightUser);
        }

        private double CalcScope(double widthUser,double heightUser)
        {
            return widthUser * 2 + heightUser * 2;
        }

        private double CalcArea(double widthUser, double heightUser)
        {
            return widthUser * heightUser;
        }
    }
}
