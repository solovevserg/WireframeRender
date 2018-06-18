using System;
using System.Windows.Forms;
using System.Drawing;

namespace WireframeRender.ControlElements
{
    class MoveBar
    {
        public delegate void ChangeInValue(int dv);
        public delegate void DoubleChangeInValue(int dx, int dy);

        public event ChangeInValue XChanged, YChanged;
        public event DoubleChangeInValue BothChanged;

        Control element;
        private int xMouse, yMouse;

        private Graphics gph;
        private Bitmap canvas;
        private Pen pen = new Pen(Color.Gray, 5);
        private int width, height;

        public MoveBar(Control element)
        {
            this.element = element;
            width = element.Width;
            height = element.Height;
            canvas = new Bitmap(element.Width, element.Height);
            element.BackgroundImage = canvas;
            gph = Graphics.FromImage(canvas);
            element.MouseMove += Element_MouseMove;
            element.SizeChanged += Element_SizeChanged;
            DrawBox();
        }

        private void Element_SizeChanged(object sender, EventArgs e)
        {
            DrawBox();
        }

        void DrawBox()
        {
            gph.FillRectangle(new SolidBrush(Color.FromArgb(128, 255, 255, 255)), 0, 0, width, height);
            gph.DrawRectangle(pen, 0, 0, width, height);
        }

        private void Element_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                if (xMouse != e.X)                    
                    XChanged?.Invoke(e.X-xMouse);
                if (yMouse != e.Y)
                    YChanged?.Invoke(yMouse - e.Y);
                if (xMouse != e.X || yMouse != e.Y)
                    BothChanged?.Invoke(e.X - xMouse, yMouse - e.Y);
            }          
            xMouse = e.X;
            yMouse = e.Y;
        }
    }
}
