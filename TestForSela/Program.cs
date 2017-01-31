using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForSela
{
    class Program
    {
        static List<object> ShapeLst = new List<object>();
        static void Main(string[] args)
        {
            string num;

            Console.WriteLine("Welcome pal!!!");

            do
            {
                Console.WriteLine("Please choose one of the options: ");
                Console.WriteLine("1.Add new shape");
                Console.WriteLine("2.List all shapes");
                Console.WriteLine("3.Sum all circumferences");
                Console.WriteLine("4.Sum all areas");
                Console.WriteLine("5.Find biggest circumference");
                Console.WriteLine("6.Find biggest area");
                Console.WriteLine("7.Exit");
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine(" ");
                        Console.WriteLine("You Choose 1!!!!");
                        AddNewShape();
                        break;
                    case "2":
                        Console.WriteLine(" ");
                        Console.WriteLine("You Choose 2!!!!");
                        break;
                    case "3":
                        Console.WriteLine(" ");
                        Console.WriteLine("You Choose 3!!!!");
                        Console.WriteLine("The Sum Of Areas Is : " + SumAllcircumference());
                        break;
                    case "4":
                        Console.WriteLine(" ");
                        Console.WriteLine("You Choose 4!!!!");
                        Console.WriteLine("The Sum Of Areas Is : " + SumAllAreas());
                        break;
                    case "5":
                        Console.WriteLine(" ");
                        Console.WriteLine("You Choose 5!!!!");
                        Console.WriteLine("The biggest circumference Is : " + Findbiggest("circumference"));
                        break;
                    case "6":
                        Console.WriteLine(" ");
                        Console.WriteLine("You Choose 6!!!!");
                        Console.WriteLine("The biggest area Is : " + Findbiggest("Area"));
                        break;
                    case "7":
                        Console.WriteLine(" ");
                        Console.WriteLine("You Choose To Exit!!!!");
                        break;
                    default:
                        Console.WriteLine("You must choose a number between 1-7 Dear brother");
                        break;
                }
            } while (num != "7");
            Console.WriteLine("Thank you for our services as distraction");
        }

        public static void AddNewShape()
        {
            string num;
            string width;
            string height;
            string r;
            Console.WriteLine(" ");
            Console.WriteLine("Now my Friend Please choose one of the Shapes: ");
            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Circle");
            Console.WriteLine("4.Right Triangle");
            num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    Console.WriteLine("Insert Width");
                    width = Console.ReadLine();
                    Square sqr = new Square(Convert.ToDouble(width));
                    ShapeLst.Add(sqr);
                    break;
                case "2":
                    Console.WriteLine("Insert Width");
                    width = Console.ReadLine();
                    Console.WriteLine("Insert height");
                    height = Console.ReadLine();
                    Rectangle req = new Rectangle(Convert.ToDouble(width), Convert.ToDouble(height));
                    ShapeLst.Add(req);
                    break;
                case "3":
                    Console.WriteLine("Insert radius");
                    r = Console.ReadLine();
                    Circle cir = new Circle(Convert.ToDouble(r));
                    ShapeLst.Add(cir);
                    break;
                case "4":
                    Console.WriteLine("Insert Width");
                    width = Console.ReadLine();
                    Console.WriteLine("Insert height");
                    height = Console.ReadLine();
                    RightTriangle rrt = new RightTriangle(Convert.ToDouble(width), Convert.ToDouble(height));
                    ShapeLst.Add(rrt);
                    break;
                default:
                    Console.WriteLine("You must choose a number between 1-4 Cowboy!");
                    break;
            }
        }

        public static string SumAllAreas()
        {
            double sum = 0;
            foreach (Shap obj in ShapeLst)
            {
                sum += obj.Area;
            }
            return Convert.ToString(sum);
        }

        public static string SumAllcircumference()
        {
            double sum = 0;
            foreach (Shap obj in ShapeLst)
            {
                sum += obj.Scope;
            }
            return Convert.ToString(sum);
        }
        
        public static string Findbiggest(string shape)
        {
            Shap max = new Shap();
            switch (shape)
            {
                case "Area":
                    foreach(Shap obj in ShapeLst)
                    {
                        if (obj.Area > max.Area)
                        {
                            max = obj;
                        }
                    }
                    return max.Name + ":" + max.Area;
                case "circumference":
                    foreach (Shap obj in ShapeLst)
                    {
                        if (obj.Scope > max.Scope)
                        {
                            max = obj;
                        }
                    }
                    return max.Name + ":" + max.Scope;
            }
            return "";
            
        }
    }
}
