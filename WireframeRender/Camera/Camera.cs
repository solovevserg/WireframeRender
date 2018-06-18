using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WireframeRender.Camera
{
    /// <summary> Класс камеры, расположенной в некотором пространстве </summary>
    class Camera
    {

        public delegate void Doing();

        public event Doing Changed;

        //положение камеры в глобальных координатах
        public Position Pos { get; set; }

        private int prevPosCode;

        public int GetPosCode()
        {
            return (int)(10000 * (Pos.Location.X + Pos.Location.Y + Pos.Location.Z + Pos.Orientation.Rotation + Pos.Orientation.Incline));
        }

        private int prevProjCode;

        public int GetProjCode()
        {
            return (Orthogonal ? 1 : 0) + 20 * Focus;
        }

        //поле для холста
        private Bitmap bitmap;

        //метод доступа к полю bitmap
        public Bitmap Screen
        {
            get { return bitmap; }
            set
            {
                bitmap = value;
                graph = Graphics.FromImage(Screen);
            }
        }

        //связанный с холстом bitmap объект класса graphics
        Graphics graph;

        //пространство, в котором находится камера
        private Space space;

        //свойство для получения информации пространстве, в котором находится камера
        public Space Space
        {
            get { return space; }
        }

        Pen pen;
        SolidBrush brush;

        // *** CAMERA SETTINGS *** //

        #region Camera Default Values
        public const bool DisplayPointsDefault = false;
        public const bool DisplayLinesDefault = true;
        public const bool OrthogonalDefault = false;
        public const double OrthogonalScaleDefault = 1;
        public const int LinesWidthDefault = 1;
        public const int PointSizeDefault = 5;
        public const bool PerpectiveEffectDefault = false;
        public const int FocusDefault = 1000;
        public Color ColorDefault = Color.Black;
        #endregion

        //фокусное расстояние камеры (по факту, расстояние от матрицы до объектива)
        public int Focus { get; set; }
        public bool DisplayPoints { get; set; }
        public bool DisplayLines { get; set; }
        public bool Orthogonal { get; set; }
        public double OrthogonalScale { get; set; }
        public int linesWidth;
        public int LinesWidth
        {
            set
            {
                linesWidth = value;
                pen = new Pen(Color, linesWidth);
            }
            get
            {
                return linesWidth;
            }
        }
        public int PointSize { get; set; }
        public bool PerspectiveEffect { get; set; }
        private Color color;
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                pen = new Pen(Color, LinesWidth);
                brush = new SolidBrush(Color);
            }
        }


        public void ResetSettings()
        {
            DisplayPoints = DisplayPointsDefault;
            DisplayLines = DisplayLinesDefault;
            Orthogonal = OrthogonalDefault;
            OrthogonalScale = OrthogonalScaleDefault;
            LinesWidth = LinesWidthDefault;
            PointSize = PointSizeDefault;
            PerspectiveEffect = PerpectiveEffectDefault;
            Focus = FocusDefault;
            Color = ColorDefault;
        }

        //конструктор по умолчанию
        public Camera(Space spaceIn)
        {
            space = spaceIn;
            Initialization();
        }

        private void Initialization()
        {
            //ResetSettings();
            Screen = new Bitmap(400, 200);
            Pos = new Position();
            Pos.Orientation = new Direction(Math.PI / 2);
            graph = Graphics.FromImage(Screen);
            ResetSettings();
        }

        public void Redraw()
        {
            graph.Clear(Color.Transparent);
            if (space != null)
            {
                foreach (Object.Object obj in Space.Objects)
                {
                    if (!obj.Hidden)
                        Draw(obj);
                }
                //for (int i = 0; i < Space.Objects.Count; i++)
                //{
                //    Position origin = Space.Objects[i].Pos.InPosition(Pos);
                //    graph.DrawString(origin.ToString(), SystemFonts.DialogFont, Brushes.Black, 10, 25 + 15 * i);
                //}
                //graph.DrawString(Pos.ToString(), SystemFonts.DialogFont, Brushes.Black, 10, 10);
                prevPosCode = GetPosCode();
                prevProjCode = GetProjCode();
            }
            else
                try
                {
                    graph.DrawImage(Properties.Resources.Logo1, 0, 0);
                }
                catch
                {

                }

            Changed?.Invoke();
        }

        private void Draw(Object.Object obj)
        {
            Project(obj);
            if (DisplayLines)
                DrawLines(obj);
            if (DisplayPoints)
                DrawPoints(obj);
        }

        private IEnumerable<Model.Vertex> localCamera;
        private List<Point> projected;
        private List<double> distances;

        private void Project(Object.Object obj)
        {
            localCamera = obj.GlobalSpace.Select(vertex => vertex.InPosition(Pos));
            if (PerspectiveEffect)
            {
                List<Model.Vertex> listCamera = localCamera.ToList();
                distances = listCamera.Select(vertex => GetDistance(vertex)).ToList();
            }
            if (!Orthogonal)
                projected = localCamera.Select(vertex => PerspectiveProjection(vertex)).ToList();
            else
                projected = localCamera.Select(vertex => OrthogonalProjectection(vertex)).ToList();
        }

        private void DrawLines(Object.Object obj)
        {
            foreach (Model.Edge edge in obj.Model.Edges)
                if (projected[edge.AIndex].X != -1 && projected[edge.BIndex].Y != -1)
                    graph.DrawLine(PerspectiveEffect ? new Pen(Color, (float)EvaluateWidth(edge)) : pen, projected[edge.AIndex], projected[edge.BIndex]);
        }

        private void DrawPoints(Object.Object obj)
        {
            for (int i = 0; i < projected.Count; i++)
            {
                Point point = projected[i];
                Rectangle rect = new Rectangle(point.X - PointSize / 2, point.Y - PointSize / 2, PointSize, PointSize);
                graph.FillEllipse(brush, rect);
            }
        }

        private double EvaluateWidth(Model.Edge edge)
        {
            return 9 / ((distances[edge.AIndex] + distances[edge.BIndex]) + 1) + 1;
        }

        private double GetDistance(Model.Vertex vertex)
        {
            return Math.Sqrt(Math.Pow(vertex.X, 2) + Math.Pow(vertex.Y, 2) + Math.Pow(vertex.Z, 2));
        }

        Point OrthogonalProjectection(Model.Vertex converted)
        {
            return new Point(Screen.Width / 2 + (int)(converted.X * 500 * OrthogonalScale), Screen.Height / 2 + (int)(-converted.Z * 500 * OrthogonalScale));
        }

        Point PerspectiveProjection(Model.Vertex converted)
        {
            return converted.Y > 0.01 ? new Point(Screen.Width / 2 + (int)(converted.X / converted.Y * Focus), Screen.Height / 2 + (int)(-converted.Z / converted.Y * Focus)) : new Point(-1, -1);
        }

        public void Dispose()
        {
            space = null;
            bitmap.Dispose();
            graph.Dispose();
        }
    }
}
