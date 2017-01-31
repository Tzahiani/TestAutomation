using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestForSela
{
    class Circle: Shap
    {
        private double radius;

        public double Radius { get { return radius; } set { radius = value; } }


        public Circle(double r)
        {
            Name = "Circle";
            Radius = r;
            Scope = CalcScope(r);
            Area = CalcArea(r);
        }

        private double CalcScope(double r)
        {
            return 2 * Math.PI * r;
        }

        private double CalcArea(double r)
        {
            return Math.PI * Math.Pow(r,2);
        }
    }
}
