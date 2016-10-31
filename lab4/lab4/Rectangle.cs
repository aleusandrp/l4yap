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

    delegate void area();
    delegate void vertex(string s);

    class Rectangle
    {
        void area()
        {
            Console.WriteLine("Событие 1: Площадь равна единице!");
        }

        void vertex(string s)
        {
            Console.WriteLine("Событие 2:" +s+ " нулевая!");
        }

        public event area ar;
        public event vertex ver;


        private Points vertexOne;
        private Points vertexTwo;
        private Points vertexThree;
        private Points vertexFour;

        public Points VertexOne
        {
            get { return vertexOne; }
            set
            {
                if (ar != null)
                {
                    if (value.X == 0) 
                        ver("Координата X вершины 1");
                    if (value.Y == 0)
                        ver("Координата Y вершины 1");
                }
                vertexOne = value;
                CheckArea();
            }
        }
        public Points VertexTwo
        {
            get { return vertexTwo; }
            set
            {
                if (ar != null)
                {
                    if (value.X == 0)
                        ver("Координата X вершины 2");
                    if (value.Y == 0)
                        ver("Координата Y вершины 2");
                }
                vertexTwo = value;
                CheckArea();
            }
        }
        public Points VertexThree
        {
            get { return vertexThree; }
            set
            {
                if (ar != null)
                {
                    if (value.X == 0)
                        ver("Координата X вершины 3");
                    if (value.Y == 0)
                        ver("Координата Y вершины 3"); ;
                }
                vertexThree = value;
                CheckArea();
            }
        }

        public Points VertexFour
        {
            get { return vertexFour; }
            set
            {
                if (ar != null)
                {
                    if (value.X == 0)
                        ver("Координата X вершины 4");
                    if (value.Y == 0)
                        ver("Координата Y вершины 4");
                }
                vertexFour = value;
                CheckArea();
            }
        }

        public Rectangle()
        {
        }
        public Rectangle(Points vertexOne, Points vertexTwo, Points vertexThree, Points vertexFour)
        {
            ar += area;
            ver += vertex;
            VertexOne = vertexOne;
            VertexTwo = vertexTwo;
            VertexThree = vertexThree;
            VertexFour = vertexFour;
           
        }


        public double CheckArea()
        {
            double side = Math.Sqrt(Math.Pow(VertexTwo.X - VertexOne.X, 2) + Math.Pow(VertexTwo.Y - VertexOne.Y, 2));
            double result = Math.Pow(side, 2);
            if(result==1 && ar != null)
                ar();


            return result;
        }




    }
}
