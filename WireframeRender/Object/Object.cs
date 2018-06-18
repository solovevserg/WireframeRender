using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WireframeRender.Object
{
    class Object
    {
        public string Name { get; set; }
        
        private Model.Model model;
        public Model.Model Model
        {
            get { return model; }
        }

        public Position Pos { get; set; }
        public int getPosCode()
        {
            return (int)(1000000 * (Pos.Location.X + Pos.Location.Y + Pos.Location.Z + Pos.Orientation.Rotation + Pos.Orientation.Incline));
        }
        private int prevPosCode;

        public double Size { get; set; }
        private double prevSize;

        public bool Hidden { get; set; }

        #region Object Default Values
        const double SizeDefault = 1;
        const bool HiddenDefault = false;
        #endregion

        private IEnumerable<Model.Vertex> sized { get; set; } // координаты точек в локальной системе координат модели после применения масштабирования
        private IEnumerable<Model.Vertex> globalSpace; // координаты точек в глобальной системе координат

        public IEnumerable<Model.Vertex> Sized
        {
            get
            {
                if (Size != prevSize || sized == null)// если изменился размер объекта
                {
                    sized = Model.Vertexes.Select(vertex => vertex.Scale(Size)); 
                    prevSize = Size;
                }
                return sized;
            }
        }

        public IEnumerable<Model.Vertex> GlobalSpace
        {
            get
            {
                if (getPosCode() != prevPosCode || globalSpace == null) //если изменилось положение объекта
                {
                    globalSpace = Sized.Select(vertex => vertex.FromPosition(Pos));
                    prevPosCode = getPosCode();
                }
                return globalSpace;
            }
        }

        public Object(Model.Model modelIn)
        {
            model = modelIn;
            ResetSettings();        
        }

        public Object(string path)
        {
            Model.ObjReader or = new Model.ObjReader(path);
            model = or.Read();
            ResetSettings();
        }

        public void ResetSettings()
        {
            Hidden = HiddenDefault;
            Size = SizeDefault;
            Pos = new Position();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
