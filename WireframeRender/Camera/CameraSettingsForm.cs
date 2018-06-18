using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WireframeRender.Extensions;

namespace WireframeRender.Camera
{
    partial class CameraSettingsForm : Form
    {
        Camera camera;
        Controller cameraCtrl;
        Provider provider;

        public CameraSettingsForm(Controller cameraCtrlIn)
        {
            cameraCtrl = cameraCtrlIn;
            camera = cameraCtrlIn.Camera;
            provider = new Provider(this, cameraCtrlIn);
            InitializeComponent();
            Initialization();
            UpdateElements();
            GotFocus += CameraSettingsForm_GotFocus;
          
        }

        private void CameraSettingsForm_GotFocus(object sender, EventArgs e)
        {
            UpdateElements();
        }

        void Initialization()
        {
            cb_display.Items.Add("points");
            cb_display.Items.Add("lines");
            cb_display.Items.Add("all");
            //cb_display.SelectedItem = "lines";
            cb_centre.Items.Add("origin");
            //cb_centre.SelectedItem = "origin";
            Random generator = new Random();
            BackColor = generator.Color();
        }

        void UpdateElements()
        {
            cb_display.SelectedItem = provider.DisplayElements;
            tb_width.Value = provider.LinesWidth;
            tb_size.Value = provider.PointSize;
            tb_colour.Value = provider.Color;
            cb_perpective.Checked = provider.PerpectiveEffect;
            tb_focus.Value = provider.Focus;
            tb_movement.Value = provider.MovementVelocity;
            tb_rotation.Value = provider.RotationVelocity;
            cb_rotation.Checked = provider.AroundCentre;
            cb_centre.SelectedItem = provider.RotationCentre;
            tb_distance.Value = provider.OrthogonalScale;
            cb_orthogonal.Checked = provider.Orthogonal;
            cb_centre.Items.Clear();
            cb_centre.Items.Add("origin");
            if (camera.Space != null)
            foreach (Object.Object obj in camera.Space.Objects)
                cb_centre.Items.Add(obj.Name);
            cb_centre.SelectedItem = provider.RotationCentre;
        }
            
        private void b_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            camera.ResetSettings();
            cameraCtrl.ResetSettings();
            UpdateElements();
            RefreshCamera();
        }

        private void cb_display_SelectedIndexChanged(object sender, EventArgs e)
        {
            provider.DisplayElements = cb_display.SelectedItem.ToString();
            UpdateEnability();
            RefreshCamera();
        }

        private void tb_width_Scroll(object sender, EventArgs e)
        {
            provider.LinesWidth = tb_width.Value;
            RefreshCamera();
        }

        private void tb_size_Scroll(object sender, EventArgs e)
        {
            provider.PointSize = tb_size.Value;
            RefreshCamera();
        }

        private void tb_colour_Scroll(object sender, EventArgs e)
        {
            provider.Color = tb_colour.Value;
            RefreshCamera();
        }

        private void cb_perpective_CheckedChanged(object sender, EventArgs e)
        {
            provider.PerpectiveEffect = cb_perpective.Checked;
            RefreshCamera();
        }

        private void tb_focus_Scroll(object sender, EventArgs e)
        {
            provider.Focus = tb_focus.Value;
            RefreshCamera();
        }

        private void tb_movement_Scroll(object sender, EventArgs e)
        {
            provider.MovementVelocity = tb_movement.Value;
            RefreshCamera();
        }

        private void tb_rotation_Scroll(object sender, EventArgs e)
        {
            provider.RotationVelocity = tb_rotation.Value;
            RefreshCamera();
        }

        private void cb_rotation_CheckedChanged(object sender, EventArgs e)
        {
            provider.AroundCentre = cb_rotation.Checked;
           // if (cb_rotation.Checked)
                //provider.Distance = Math.Sqrt(Math.Pow(cameraCtrl.RotationCentre?.Pos.Location.Z ?? 0, 2), );
            cb_orthogonal.Checked = false;
            RefreshCamera();
            UpdateEnability();
        }

        private void cb_centre_SelectedIndexChanged(object sender, EventArgs e)
        {
            provider.RotationCentre = cb_centre.SelectedItem?.ToString();
            RefreshCamera();
        }

        private void tb_distance_Scroll(object sender, EventArgs e)
        {
            //DISTACNE
            provider.OrthogonalScale = tb_distance.Value;
            RefreshCamera();
        }

        private void cb_orthogonal_CheckedChanged(object sender, EventArgs e)
        {
            provider.Orthogonal = cb_orthogonal.Checked;
            RefreshCamera();
            UpdateEnability();
        }

        private void RefreshCamera()
        {
            camera.Redraw();
            //cameraCtrl.ThrowChanged();
        }

        private void UpdateEnability()
        {
            tb_width.Enabled = true;
            tb_size.Enabled = true;
            if (provider.DisplayElements == "points")
                tb_width.Enabled = false;
            else if (provider.DisplayElements == "lines")
                tb_size.Enabled = false;

                cb_centre.Enabled = provider.AroundCentre;
                cb_orthogonal.Enabled = provider.AroundCentre;
                tb_distance.Enabled = provider.AroundCentre && provider.Orthogonal;
        }
    }
}
