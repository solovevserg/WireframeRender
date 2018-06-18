using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireframeRender.Model
{
    class Vertex
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vertex(double  xIn, double yIn, double zIn)
        {
            Set(xIn, yIn, zIn);
        }

        public Vertex()
        {
            Set(0, 0, 0);
        }

        public Vertex(Vertex vertex)
        {
            X = vertex.X;
            Y = vertex.Y;
            Z = vertex.Z;
        }

        public void Set(double xIn, double yIn, double zIn)
        {
            X = xIn;
            Y = yIn;
            Z = zIn;
        }

        public void add(double dx, double dy, double dz)
        {
            //Set(X + DX, Y + DY, Z + DZ);
            X += dx;
            Y += dy;
            Z += dz;
        }

        //возвращает точку this, заданную в системе координат с положением origin (точка и система должны быть заданы в одной глобальной системе координат)
        public Vertex InPosition(Position origin)
        {
            double a = origin.Orientation.Rotation;
            double b = origin.Orientation.Incline;

            Vertex vertex1 = Move(origin.Location);

            //Vertex vertex2 = new Vertex(vertex1);
            //vertex2.X = vertex1.X;
            //vertex2.Y = vertex1.Y * Math.Cos(b) + vertex1.Z * Math.Sin(b);
            //vertex2.Z = -vertex1.Y * Math.Sin(b) + vertex1.Z * Math.Cos(b);


            //vertex1.X = vertex2.X * Math.Cos(a) + vertex2.Y * Math.Sin(a);
            //vertex1.Y = -vertex2.X * Math.Sin(a) + vertex2.Y * Math.Cos(a);
            //vertex1.Z = vertex2.Z;

            Vertex vertex2 = new Vertex(vertex1);
            vertex2.X = vertex1.X * Math.Cos(a) + vertex1.Y * Math.Sin(a);
            vertex2.Y = -vertex1.X * Math.Sin(a) + vertex1.Y * Math.Cos(a);
            vertex2.Z = vertex1.Z;

            vertex1.X = vertex2.X;
            vertex1.Y = vertex2.Y * Math.Cos(b) + vertex2.Z * Math.Sin(b);
            vertex1.Z = -vertex2.Y * Math.Sin(b) + vertex2.Z * Math.Cos(b);

            return vertex1;
        }



        public Vertex FromPosition(Position origin)
        {
            double a = origin.Orientation.Rotation;
            double b = origin.Orientation.Incline;

            Vertex vertex2 = new Vertex(this);
            Vertex vertex1 = new Vertex();

            vertex1.X = vertex2.X;
            vertex1.Y = vertex2.Y * Math.Cos(b) - vertex2.Z * Math.Sin(b);
            vertex1.Z = vertex2.Y * Math.Sin(b) + vertex2.Z * Math.Cos(b);

            vertex2.X = vertex1.X * Math.Cos(a) - vertex1.Y * Math.Sin(a);
            vertex2.Y = vertex1.X * Math.Sin(a) + vertex1.Y * Math.Cos(a);
            vertex2.Z = vertex1.Z;

            //vertex1.X = vertex2.X * Math.Cos(a) - vertex2.Y * Math.Sin(a);
            //vertex1.Y = vertex2.X * Math.Sin(a) + vertex2.Y * Math.Cos(a);
            //vertex1.Z = vertex2.Z;

            //vertex2.X = vertex1.X;
            //vertex2.Y = vertex1.Y * Math.Cos(b) - vertex1.Z * Math.Sin(b);
            //vertex2.Z = vertex1.Y * Math.Sin(b) + vertex1.Z * Math.Cos(b);

            vertex1 = vertex2.Move(origin.Location.Inverse());

            return vertex1;
            //return this;
            //return InPosition(origin.Inverse());
        }

        public Vertex Move(Vertex origin)
        {
            return new Vertex(X - origin.X, Y - origin.Y, Z - origin.Z);
        }

        public Vertex Inverse()
        {
            return new Vertex(-X, -Y, -Z);
        }

        override public string ToString()       
        {
            return "x:" + ((int)(X*100)).ToString() + " y:" + ((int)(Y * 100)).ToString() + " z:" + ((int)(Z * 100)).ToString();
        }

        public Vertex Scale(double coefficient)
        {
            return new Vertex(X * coefficient, Y * coefficient, Z * coefficient);
        }
    }
}
