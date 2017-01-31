using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForSela
{
    class Square :Shap
    {

        private double width;

        public double Width{ get { return width; } set { width = value; } }


        public Square(double widthUser)
        {
            Name = "Square";
            Width = widthUser;
            Scope = CalcScope(widthUser);
            Area = CalcArea(widthUser);
        }

        private double CalcScope(double widthUser)
        {
            return widthUser * 4.0;
        }

        private double CalcArea(double widthUser)
        {
            return widthUser * widthUser;
        }
    }
}
