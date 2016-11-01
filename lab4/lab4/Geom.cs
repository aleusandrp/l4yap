using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    struct Points
    {
        public Points(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
    }

    delegate void Square();
    delegate void Top(string s);

    class Geom
    {
        void Square()
        {
            Console.WriteLine("Площадь = 1");
        }

        void Top(string s)
        {
            Console.WriteLine(s+ " = 0");
        }

        public event Square Squaree;
        public event Top Topp;


        private Points vertexOne;
        private Points vertexTwo;
        private Points vertexThree;
        public Points vertexFour;

        public Points VertexOne
        {
            get { return vertexOne; }
            set
            {
                if (Squaree != null)
                {
                    if (value.X == 0) 
                        Topp("X вершины 1");
                    if (value.Y == 0)
                        Topp("Y вершины 1");
                }
                vertexOne = value;
                CheckSquare();
            }
        }
        public Points VertexTwo
        {
            get { return vertexTwo; }
            set
            {
                if (Squaree != null)
                {
                    if (value.X == 0)
                        Topp("X вершины 2");
                    if (value.Y == 0)
                        Topp("Y вершины 2");
                }
                vertexTwo = value;
                CheckSquare();
            }
        }
        public Points VertexThree
        {
            get { return vertexThree; }
            set
            {
                if (Squaree != null)
                {
                    if (value.X == 0)
                        Topp("X вершины 3");
                    if (value.Y == 0)
                        Topp("Y вершины 3"); ;
                }
                vertexThree = value;
                CheckSquare();
            }
        }
        public Points VertexFour
        {
            get { return vertexFour; }
            set
            {
                if (Squaree != null)
                {
                    if (value.X == 0)
                        Topp("X вершины 4");
                    if (value.Y == 0)
                        Topp("Y вершины 4");
                }
                vertexFour = value;
                CheckSquare();
            }
        }

        public Geom(Points vertexOne, Points vertexTwo, Points vertexThree, Points vertexFour)
        {
            Squaree += Square;
            Topp += Top;
            VertexOne = vertexOne;
            VertexTwo = vertexTwo;
            VertexThree = vertexThree;
            VertexFour = vertexFour;
           
        }

        public double CheckSquare()
        {
            double result = Math.Pow(Math.Sqrt(Math.Pow(VertexTwo.X - VertexOne.X, 2) + Math.Pow(VertexTwo.Y - VertexOne.Y, 2)), 2);
            if(result == 1 && Squaree != null)
                Squaree();

            return result;
        }
    }
}
