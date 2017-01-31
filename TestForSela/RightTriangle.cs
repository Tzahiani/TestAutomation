using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForSela
{
    class RightTriangle : Shap
    {
        private double width;
        private double height;



        public double Width { get { return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }


        public RightTriangle(double widthUser, double heightUser)
        {
            Name = "Right Triangle";
            Width = widthUser;
            Height = heightUser;
            Scope = CalcScope(widthUser, heightUser);
            Area = CalcArea(widthUser, heightUser);
        }

        private double CalcScope(double widthUser, double heightUser)
        {
            return widthUser + heightUser + Math.Sqrt(Math.Pow(widthUser, 2) + Math.Pow(heightUser, 2));
        }

        private double CalcArea(double widthUser, double heightUser)
        {
            return (widthUser * heightUser) / 2;
        }
    }
}
