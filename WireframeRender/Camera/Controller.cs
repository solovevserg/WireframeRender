using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WireframeRender.Camera
{
    class Controller
    {
        private Camera camera;
        private Control element;
        public Control Element { get { return element;} }
        public Camera Camera { get { return camera; } }

        public int MovementVelocity { get; set; }
        public int RotationVelocity { get; set; }
        public bool AroundCentre { get; set; }
        public Object.Object RotationCentre { get; set; } //если равен нулю, то вращение происходит относительно начала координат
        private double distance;
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = Math.Max(value, 0);
            }
        }

        #region Camera.Controller Default Values
        public const int MovementVelocityDefault = 9;
        public const int RotationVelocityDefault = 3;
        public const bool AroundCentreDefault = false;
        public readonly Object.Object RotationCentreDefault = null; //если равен нулю, то вращение происходит относительно начала координат
        public const double DistanceDefault = 1;
        private int xMouse, yMouse;
        #endregion

        public void ResetSettings()
        {
            MovementVelocity = MovementVelocityDefault;
            RotationVelocity = RotationVelocityDefault;
            AroundCentre = AroundCentreDefault;
            RotationCentre = RotationCentreDefault;
            Distance = DistanceDefault;
        }


        public Controller(Camera cameraIn, Control elementIn)
        {
            camera = cameraIn;
            element = elementIn;
            element.MouseMove += Element_MouseMove;           
            xMouse = element.Width / 2;
            yMouse = element.Height / 2;
            ResetSettings();
        }

        private void Element_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                camera.Pos.Orientation.Rotation += ((double)(e.X - xMouse)) / 2000 * RotationVelocity * (AroundCentre ? -1:1);
                camera.Pos.Orientation.Incline += ((double)(e.Y - yMouse)) / 2000 * RotationVelocity * (AroundCentre ? -1 : 1);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                if (!AroundCentre)
                    camera.Pos.Location = new Model.Vertex((double)(xMouse - e.X) / 1000 * MovementVelocity, 0, (double)(e.Y - yMouse) / 1000 * MovementVelocity).FromPosition(camera.Pos);
            }
            else if (e.Button == MouseButtons.Left && !camera.Orthogonal)
            {
                if (AroundCentre)
                    Distance += (double)(e.Y - yMouse) / 1000 * MovementVelocity;
                else
                    camera.Pos.Location = new Model.Vertex(0, (double)(yMouse - e.Y) / 1000 * MovementVelocity, 0).FromPosition(camera.Pos);
            }
            if (AroundCentre)
            {
                camera.Pos.Location.X = Math.Cos(-camera.Pos.Orientation.Incline) * Distance;
                camera.Pos.Location.Z = (RotationCentre?.Pos.Location.Z ?? 0) + Distance * Math.Sin(-camera.Pos.Orientation.Incline);
                camera.Pos.Location.Y = (RotationCentre?.Pos.Location.Y ?? 0) + camera.Pos.Location.X * Math.Sin(camera.Pos.Orientation.Rotation - Math.PI / 2);
                camera.Pos.Location.X = (RotationCentre?.Pos.Location.X ?? 0) + camera.Pos.Location.X * Math.Cos(camera.Pos.Orientation.Rotation - Math.PI / 2);
            }
            if (e.Button != MouseButtons.None)
                camera.Redraw();

            xMouse = e.X;
            yMouse = e.Y;
        }

        public void UpdateCamera()
        {
            camera.Redraw();
        }

        public void Dispose()
        {
            camera = null;
            element.MouseMove -= Element_MouseMove;
            element = null;            
        }
    }
}
