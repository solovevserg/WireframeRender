using System;
using System.Windows.Forms;
using WireframeRender.Extensions;

namespace WireframeRender.Object
{
    partial class ObjectSettingsForm : Form
    {
        public delegate void Doing();
        public event Doing Changed;
        public event Doing PropertiesWasChanged;

        private Space space;
        private Object obj;
        private Provider provider;

        public Object Object
        {
            get
            {
                return obj;
            }
        }

        ControlElements.RotationBar rb_incline;
        ControlElements.RotationBar rb_rotation;

        public ObjectSettingsForm(Space space, Object obj)
        {
            InitializeComponent();
            Random generator = new Random();
            BackColor = generator.Color();
            this.space = space;
            this.obj = obj;
            provider = new Provider(obj);
            tb_name.LostFocus += Tb_name_LostFocus;
            GotFocus += ObjectSettingsForm_GotFocus;
            (new ControlElements.MoveBar(pb_size)).XChanged += ObjectSettingsForm_XChanged;
            (new ControlElements.MoveBar(pb_z)).YChanged += ObjectSettingsForm_YChanged;
            (new ControlElements.MoveBar(pb_xy)).BothChanged += ObjectSettingsForm_BothChanged;
            rb_incline = new ControlElements.RotationBar(pb_incline, -obj.Pos.Orientation.Incline);
            rb_incline.AngleWasSet += ObjectSettingsForm_InclineWasSet;
            rb_rotation = new ControlElements.RotationBar(pb_rotation, -obj.Pos.Orientation.Rotation);
            rb_rotation.AngleWasSet += ObjectSettingsForm_RotationWasSet;
            UpdateElements();
        }

        private void ObjectSettingsForm_GotFocus(object sender, EventArgs e)
        {
            UpdateElements();
        }

        private void UpdateElements()
        {
            cb_hide.Checked = provider.Hidden;
            tb_name.Text = provider.Name;
            rb_rotation.CurrentAngle = -obj.Pos.Orientation.Rotation;
            rb_incline.CurrentAngle = -obj.Pos.Orientation.Incline;
        }

        private void ObjectSettingsForm_RotationWasSet(double a)
        {
            obj.Pos.Orientation.Rotation = -a;
            Changed?.Invoke();
        }

        private void ObjectSettingsForm_InclineWasSet(double a)
        {
            obj.Pos.Orientation.Incline = -(a<Math.PI? a : a-2*Math.PI);
            Changed?.Invoke();
        }

        private void ObjectSettingsForm_BothChanged(int dx, int dy)
        {
            provider.AddCoordinates(dx, dy, 0);
            Changed?.Invoke();
        }

        private void ObjectSettingsForm_YChanged(int dv)
        {
            provider.AddCoordinates(0, 0, dv);
            Changed?.Invoke();
        }

        private void ObjectSettingsForm_XChanged(int dv)
        {
            provider.IncreaseSize(dv);
            Changed?.Invoke();
        }

        private void Tb_name_LostFocus(object sender, EventArgs e)
        {
            if (space.Objects.Find(obj => obj.Name == tb_name.Text) == null)
            {
                provider.Name = tb_name.Text;
                PropertiesWasChanged?.Invoke();
            }
            else
                tb_name.Text = provider.Name;
        }

        private void b_hide_Click(object sender, EventArgs e)
        {
            foreach (Object objct in space.Objects)
                objct.Hidden = true;
            provider.Hidden = false;
            cb_hide.Checked = false;
            Changed?.Invoke();
        }

        private void b_default_Click(object sender, EventArgs e)
        {
            obj.ResetSettings();
            Changed?.Invoke();
            rb_rotation.Reset();
            rb_incline.Reset();
            UpdateElements();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            space.Objects.Remove(obj);
            Changed?.Invoke();
            PropertiesWasChanged?.Invoke();
            Close();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_hide_CheckedChanged(object sender, EventArgs e)
        {
            provider.Hidden = cb_hide.Checked;
            Changed?.Invoke();
        }
    }
}
