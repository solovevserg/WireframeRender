using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireframeRender
{
    class Position
    {
        public Model.Vertex Location { get; set; }
        public Direction Orientation { get; set; }

        public Position()
        {
            Location = new Model.Vertex();
            Orientation = new Direction();
        }

        public Position(Model.Vertex locationIn, Direction orientationIn)
        {
            Location = locationIn;
            Orientation = orientationIn;
        }

        //возвращает положение системы координат this в системе координат origin (Исходные положения систем должны быть заданы в одной глобальной системе координат)
        public Position InPosition(Position origin)
        {
            return new Position(Location.InPosition(origin), Orientation.Turn(origin.Orientation));
        }

        public Position Inverse()
        {
            return new Position(Location.Inverse(), Orientation.Inverse());
        }

        override public string ToString()
        {
            return "Loc (" + Location.ToString() + ") Rot (" + Orientation.ToString() + ")";
        }
    }
}
