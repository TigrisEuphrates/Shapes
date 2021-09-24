using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagon hex = new Hexagon("Beth");
            hex.Draw();

            Circle cir = new Circle("Cindy");
            cir.Draw();
            Console.WriteLine();

            Shape[] myShapes = new Shape[] {new Hexagon(),new Circle(), new Hexagon("Mick"),
                                            new Circle("Beth"), new Hexagon("Linda") };
            foreach (var s in myShapes)
            {
                s.Draw();
            }
            Console.WriteLine();

            ThreeDCircle o = new ThreeDCircle();
            o.Draw();
            ((Circle)o).Draw();
            Console.WriteLine();
        }
    }
}
