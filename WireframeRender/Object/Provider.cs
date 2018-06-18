using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireframeRender.Object
{
    class Provider
    {
        Object obj;

        public Provider(Object objIn)
        {
            obj = objIn;
        }

        public string Name
        {
            get
            {
                return obj.Name;
            }
            set
            {
                obj.Name = value;
            }
        }

        public void IncreaseSize(double coef)
        {
            obj.Size = Math.Max(obj.Size + coef * obj.Size / 100, 0.001);
        }
       
        public void AddCoordinates(double x, double y, double z)
        {
            obj.Pos.Location.X += x/10;
            obj.Pos.Location.Y += y/10;
            obj.Pos.Location.Z += z/10;
        }

        public void AddAngles(double a, double b)
        {
            obj.Pos.Orientation.Rotation += a;
            obj.Pos.Orientation.Incline += b;
        }

        public bool Hidden
        {
            get
            {
                return obj.Hidden;
            }

            set
            {
                obj.Hidden = value;
            }
        }

    }
}
