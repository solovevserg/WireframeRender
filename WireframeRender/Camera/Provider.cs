using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WireframeRender.Camera
{
    class Provider
    {
        Camera camera;
        CameraSettingsForm camSetForm;
        Controller cameraCtrl;

        public Provider(CameraSettingsForm camSetFormIn, Controller cameraCtrlIn)
        {
            camSetForm = camSetFormIn;
            cameraCtrl = cameraCtrlIn;
            camera = cameraCtrl.Camera;
        }

        public int Focus
        {
            get
            {
                return (camera.Focus / 75)-5 <= 20 ? (camera.Focus / 75) - 5 : 20;
            }
            set
            {
                camera.Focus = (value+5) * 75;
            }
        }

        public string DisplayElements
        {
            get
            {
                string temp = "all";
                if (camera.DisplayLines && camera.DisplayPoints)
                    temp = "all";
                else if (camera.DisplayPoints)
                    temp = "points";
                else if (camera.DisplayLines)
                    temp = "lines";
                return temp;
            }
            set
            {
                if (value == "all")
                {
                    camera.DisplayLines = true;
                    camera.DisplayPoints = true;
                }
                else if (value == "points")
                {
                    camera.DisplayLines = false;
                    camera.DisplayPoints = true;
                }
                else if (value == "lines")
                {
                    camera.DisplayLines = true;
                    camera.DisplayPoints = false;
                }
            }
        }

        public bool Orthogonal
        {
            get
            {
                return camera.Orthogonal;
            }
            set
            {
                camera.Orthogonal = value;
            }
        }

        public int LinesWidth
        {
            get
            {
                return camera.LinesWidth - 1;
            }
            set
            {
                camera.LinesWidth = value + 1;
            }
        }

        public int PointSize
        {
            get
            {
                return camera.PointSize - 2;
            }
            set
            {
                camera.PointSize = value + 2;
            }
        }

        public bool PerpectiveEffect
        {
            get
            {
                return camera.PerspectiveEffect;
            }
            set
            {
                camera.PerspectiveEffect = value;
            }
        }

        public int Color
        {
            get
            {
                int result = 0;
                if (camera.Color == System.Drawing.Color.Red)
                    result = 1;
                if (camera.Color == System.Drawing.Color.Blue)
                    result = 2;
                if (camera.Color == System.Drawing.Color.Green)
                    result = 3;
                if (camera.Color == System.Drawing.Color.Pink)
                    result = 4;
                if (camera.Color == System.Drawing.Color.SlateGray)
                    result = 5;
                return result;
            }
            set
            {
                Color result = System.Drawing.Color.Black;
                if (value == 1)
                    result = System.Drawing.Color.Red;
                if (value == 2)
                    result = System.Drawing.Color.Blue;
                if (value == 3)
                    result = System.Drawing.Color.Green;
                if (value == 4)
                    result = System.Drawing.Color.Pink;
                if (value == 5)
                    result = System.Drawing.Color.SlateGray;
                camera.Color = result;
            }
        }

        public int MovementVelocity
        {
            get
            {
                return cameraCtrl.MovementVelocity - 1;
            }
            set
            {
                cameraCtrl.MovementVelocity = value + 1;
            }
        }

        public int RotationVelocity
        {
            get
            {
                return cameraCtrl.RotationVelocity - 1;
            }
            set
            {
                cameraCtrl.RotationVelocity = value + 1;
            }
        }

        public bool AroundCentre
        {
            get
            {
                return cameraCtrl.AroundCentre;
            }
            set
            {
                cameraCtrl.AroundCentre = value;
            }
        }

        public string RotationCentre
        {
            get
            {
                return (cameraCtrl.RotationCentre?.Name)??"origin";
            }
            set
            {
                cameraCtrl.RotationCentre = camera.Space?.Objects.Find(obj => obj.Name == value);
            }
        } //если равен нулю, то вращение происходит относительно начала координат

        public int Distance
        {
            get
            {
                return (int)cameraCtrl.Distance;
            }
            set
            {
                cameraCtrl.Distance = (double)value;
            }
        }

        public int OrthogonalScale
        {
            get
            {
                return (int)(camera.OrthogonalScale * 20)-1;
            }
            set
            {
                camera.OrthogonalScale = ((double)value + 1) / 20;
            }
        }
            

    }
}
