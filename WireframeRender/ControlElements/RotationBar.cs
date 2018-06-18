using System;
using System.Windows.Forms;
using System.Drawing;

namespace WireframeRender.ControlElements
{
    class RotationBar
    {
        public delegate void Angle(double a);
        public event Angle AngleWasSet;

        private Bitmap canvas;
        private Graphics gph;
        private Control element;
        private Pen pen = new Pen(Color.Black, 5.5F);
        private Pen circlePen = new Pen(Color.Gray, 8);

        private int width;
        private int height;

        private double angle;
        public double CurrentAngle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = Math.IEEERemainder(value, Math.PI * 2);
                if (angle < 0)
                    angle += Math.PI * 2;
                DrawVector(angle);
            }
        }

        public RotationBar(Control element, double startAngle = 0)
        {
            this.element = element;
            canvas = new Bitmap(element.Width, element.Height);
            element.BackgroundImage = canvas;
            gph = Graphics.FromImage(canvas);
            width = element.Width;
            height = element.Height;
            element.MouseDown += Element_SettingAngle;
            element.MouseMove += Element_SettingAngle;
            element.SizeChanged += Element_SizeChanged;
            CurrentAngle = startAngle;
        }

        private void Element_SizeChanged(object sender, EventArgs e)
        {
            width = element.Width;
            height = element.Height;
        }

        private void Element_SettingAngle(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X - width / 2;
                int y = height / 2 - e.Y;
                CurrentAngle = Math.Atan(y / (x + 0.05)) + (x < 0 ? Math.PI : 0);
                AngleWasSet?.Invoke(CurrentAngle);
            }
        }

        void DrawVector(double a)
        {
            DrawCircle();
            gph.DrawLine(pen, width / 2, height / 2, (int)(width / 2 * (1 + Math.Cos(a))), (int)(height / 2 * (1 - Math.Sin(a))));
            element.Refresh();
        }

        void DrawCircle()
        {
            gph.Clear(Color.Transparent);
            gph.FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 255, 255)), 0, 0, width, height);
            gph.DrawEllipse(circlePen, 4, 4, width-8, height-8);
            //gph.FillEllipse(new SolidBrush(Color.White), width / 6, height / 6, width * 2 / 3, height * 2 / 3);
        }

        public void Reset()
        {
            CurrentAngle = 0;
        }
    }
}
