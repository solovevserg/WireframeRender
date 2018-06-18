using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireframeRender
{
    class Direction
    {
        private readonly double limit;

        private double rotation;
        public double Rotation
        {
            get
            {
                return rotation;
            }
            set
            {
                rotation = (value) - ((int)(value / (Math.PI * 2))) * 2 * Math.PI;
                if (rotation < 0)
                    rotation += 2 * Math.PI;
            }
        }

        private double incline;
        public double Incline
        {
            get
            {
                return incline;
            }
            set
            {
                incline = value;
                if (incline > limit)
                    incline = limit;
                else if (incline < -limit)
                    incline = -limit;
            }
        }

        public Direction(double limit = Math.PI)
        {
            this.limit = limit;
            Rotation = 0;
            Incline = 0;
        }

        public Direction(double rotationIn, double inclineIn, double limit = Math.PI)
        {
            this.limit = limit;
            Incline = inclineIn;
            Rotation = rotationIn;
        }

        public Direction InPosition(Position origin)
        {
            return new Direction(Rotation - origin.Orientation.Rotation, Incline - origin.Orientation.Incline);
        }

        public Direction Inverse()
        {
            return new Direction(-Rotation, -Incline);
        }

        public Direction Turn(Direction origin)
        {
            return new Direction(Rotation - origin.Rotation, Incline - origin.Incline);
        }

        public override string ToString()
        {
            return "a:" + (Rotation * 180 / Math.PI).ToString() + " b:" + (Incline * 180 / Math.PI).ToString();
        }
    }
}
