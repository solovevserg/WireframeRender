namespace WireframeRender.Camera
{
    partial class CameraSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraSettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_width = new System.Windows.Forms.TrackBar();
            this.tb_size = new System.Windows.Forms.TrackBar();
            this.tb_movement = new System.Windows.Forms.TrackBar();
            this.tb_rotation = new System.Windows.Forms.TrackBar();
            this.cb_centre = new System.Windows.Forms.ComboBox();
            this.cb_rotation = new System.Windows.Forms.CheckBox();
            this.cb_display = new System.Windows.Forms.ComboBox();
            this.cb_orthogonal = new System.Windows.Forms.CheckBox();
            this.tb_colour = new System.Windows.Forms.TrackBar();
            this.cb_perpective = new System.Windows.Forms.CheckBox();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.tb_distance = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_focus = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tb_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_movement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_colour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_focus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera Settings Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Display elements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lines width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Points size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Movement velocity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rotation Velocity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Camera rotation centre point";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Scale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Colour";
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(12, 101);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(146, 45);
            this.tb_width.TabIndex = 1;
            this.tb_width.Scroll += new System.EventHandler(this.tb_width_Scroll);
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(12, 165);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(146, 45);
            this.tb_size.TabIndex = 1;
            this.tb_size.Scroll += new System.EventHandler(this.tb_size_Scroll);
            // 
            // tb_movement
            // 
            this.tb_movement.Location = new System.Drawing.Point(190, 62);
            this.tb_movement.Maximum = 20;
            this.tb_movement.Name = "tb_movement";
            this.tb_movement.Size = new System.Drawing.Size(146, 45);
            this.tb_movement.TabIndex = 1;
            this.tb_movement.Scroll += new System.EventHandler(this.tb_movement_Scroll);
            // 
            // tb_rotation
            // 
            this.tb_rotation.Location = new System.Drawing.Point(190, 126);
            this.tb_rotation.Maximum = 20;
            this.tb_rotation.Name = "tb_rotation";
            this.tb_rotation.Size = new System.Drawing.Size(146, 45);
            this.tb_rotation.TabIndex = 1;
            this.tb_rotation.Scroll += new System.EventHandler(this.tb_rotation_Scroll);
            // 
            // cb_centre
            // 
            this.cb_centre.FormattingEnabled = true;
            this.cb_centre.Location = new System.Drawing.Point(190, 229);
            this.cb_centre.Name = "cb_centre";
            this.cb_centre.Size = new System.Drawing.Size(146, 21);
            this.cb_centre.TabIndex = 2;
            this.cb_centre.SelectedIndexChanged += new System.EventHandler(this.cb_centre_SelectedIndexChanged);
            // 
            // cb_rotation
            // 
            this.cb_rotation.AutoSize = true;
            this.cb_rotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_rotation.Location = new System.Drawing.Point(193, 177);
            this.cb_rotation.Name = "cb_rotation";
            this.cb_rotation.Size = new System.Drawing.Size(132, 17);
            this.cb_rotation.TabIndex = 3;
            this.cb_rotation.Text = "Rotation around centre";
            this.cb_rotation.UseVisualStyleBackColor = true;
            this.cb_rotation.CheckedChanged += new System.EventHandler(this.cb_rotation_CheckedChanged);
            // 
            // cb_display
            // 
            this.cb_display.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_display.FormattingEnabled = true;
            this.cb_display.Location = new System.Drawing.Point(12, 61);
            this.cb_display.Name = "cb_display";
            this.cb_display.Size = new System.Drawing.Size(146, 21);
            this.cb_display.TabIndex = 2;
            this.cb_display.SelectedIndexChanged += new System.EventHandler(this.cb_display_SelectedIndexChanged);
            // 
            // cb_orthogonal
            // 
            this.cb_orthogonal.AutoSize = true;
            this.cb_orthogonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_orthogonal.Location = new System.Drawing.Point(193, 275);
            this.cb_orthogonal.Name = "cb_orthogonal";
            this.cb_orthogonal.Size = new System.Drawing.Size(124, 17);
            this.cb_orthogonal.TabIndex = 4;
            this.cb_orthogonal.Text = "Orthogonal projection";
            this.cb_orthogonal.UseVisualStyleBackColor = true;
            this.cb_orthogonal.CheckedChanged += new System.EventHandler(this.cb_orthogonal_CheckedChanged);
            // 
            // tb_colour
            // 
            this.tb_colour.Location = new System.Drawing.Point(12, 229);
            this.tb_colour.Maximum = 5;
            this.tb_colour.Name = "tb_colour";
            this.tb_colour.Size = new System.Drawing.Size(146, 45);
            this.tb_colour.TabIndex = 1;
            this.tb_colour.Scroll += new System.EventHandler(this.tb_colour_Scroll);
            // 
            // cb_perpective
            // 
            this.cb_perpective.AutoSize = true;
            this.cb_perpective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_perpective.Location = new System.Drawing.Point(15, 275);
            this.cb_perpective.Name = "cb_perpective";
            this.cb_perpective.Size = new System.Drawing.Size(104, 17);
            this.cb_perpective.TabIndex = 5;
            this.cb_perpective.Text = "Perpective effect";
            this.cb_perpective.UseVisualStyleBackColor = true;
            this.cb_perpective.CheckedChanged += new System.EventHandler(this.cb_perpective_CheckedChanged);
            // 
            // b_reset
            // 
            this.b_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_reset.Location = new System.Drawing.Point(12, 376);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(143, 23);
            this.b_reset.TabIndex = 6;
            this.b_reset.Text = "Reset";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_close
            // 
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Location = new System.Drawing.Point(190, 376);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(146, 23);
            this.b_close.TabIndex = 6;
            this.b_close.Text = "Close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // tb_distance
            // 
            this.tb_distance.Location = new System.Drawing.Point(193, 325);
            this.tb_distance.Maximum = 20;
            this.tb_distance.Name = "tb_distance";
            this.tb_distance.Size = new System.Drawing.Size(146, 45);
            this.tb_distance.TabIndex = 1;
            this.tb_distance.Scroll += new System.EventHandler(this.tb_distance_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Focus";
            // 
            // tb_focus
            // 
            this.tb_focus.Location = new System.Drawing.Point(12, 325);
            this.tb_focus.Maximum = 20;
            this.tb_focus.Name = "tb_focus";
            this.tb_focus.Size = new System.Drawing.Size(146, 45);
            this.tb_focus.TabIndex = 1;
            this.tb_focus.Scroll += new System.EventHandler(this.tb_focus_Scroll);
            // 
            // CameraSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(351, 417);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.cb_perpective);
            this.Controls.Add(this.cb_orthogonal);
            this.Controls.Add(this.cb_rotation);
            this.Controls.Add(this.cb_display);
            this.Controls.Add(this.cb_centre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_distance);
            this.Controls.Add(this.tb_rotation);
            this.Controls.Add(this.tb_movement);
            this.Controls.Add(this.tb_focus);
            this.Controls.Add(this.tb_colour);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_width);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(367, 455);
            this.MinimumSize = new System.Drawing.Size(367, 455);
            this.Name = "CameraSettingsForm";
            this.Text = "Camera Settings";
            ((System.ComponentModel.ISupportInitialize)(this.tb_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_movement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_colour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_focus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tb_width;
        private System.Windows.Forms.TrackBar tb_size;
        private System.Windows.Forms.TrackBar tb_movement;
        private System.Windows.Forms.TrackBar tb_rotation;
        private System.Windows.Forms.ComboBox cb_centre;
        private System.Windows.Forms.CheckBox cb_rotation;
        private System.Windows.Forms.ComboBox cb_display;
        private System.Windows.Forms.CheckBox cb_orthogonal;
        private System.Windows.Forms.TrackBar tb_colour;
        private System.Windows.Forms.CheckBox cb_perpective;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.TrackBar tb_distance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tb_focus;
    }
}