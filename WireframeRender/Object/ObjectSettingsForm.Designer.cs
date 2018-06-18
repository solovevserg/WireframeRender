namespace WireframeRender.Object
{
    partial class ObjectSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectSettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_hide = new System.Windows.Forms.CheckBox();
            this.b_hide = new System.Windows.Forms.Button();
            this.b_default = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.b_close = new System.Windows.Forms.Button();
            this.pb_size = new System.Windows.Forms.PictureBox();
            this.pb_xy = new System.Windows.Forms.PictureBox();
            this.pb_incline = new System.Windows.Forms.PictureBox();
            this.pb_z = new System.Windows.Forms.PictureBox();
            this.pb_rotation = new System.Windows.Forms.PictureBox();
            this.b_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_xy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_incline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rotation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Object Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rotation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Incline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "x, y";
            // 
            // cb_hide
            // 
            this.cb_hide.AutoSize = true;
            this.cb_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_hide.Location = new System.Drawing.Point(15, 399);
            this.cb_hide.Name = "cb_hide";
            this.cb_hide.Size = new System.Drawing.Size(45, 17);
            this.cb_hide.TabIndex = 7;
            this.cb_hide.Text = "Hide";
            this.cb_hide.UseVisualStyleBackColor = true;
            this.cb_hide.CheckedChanged += new System.EventHandler(this.cb_hide_CheckedChanged);
            // 
            // b_hide
            // 
            this.b_hide.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_hide.Location = new System.Drawing.Point(70, 398);
            this.b_hide.Name = "b_hide";
            this.b_hide.Size = new System.Drawing.Size(142, 23);
            this.b_hide.TabIndex = 8;
            this.b_hide.Text = "Hide other objects";
            this.b_hide.UseVisualStyleBackColor = true;
            this.b_hide.Click += new System.EventHandler(this.b_hide_Click);
            // 
            // b_default
            // 
            this.b_default.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_default.Location = new System.Drawing.Point(10, 430);
            this.b_default.Name = "b_default";
            this.b_default.Size = new System.Drawing.Size(202, 23);
            this.b_default.TabIndex = 9;
            this.b_default.Text = "Default";
            this.b_default.UseVisualStyleBackColor = true;
            this.b_default.Click += new System.EventHandler(this.b_default_Click);
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Location = new System.Drawing.Point(12, 52);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(200, 20);
            this.tb_name.TabIndex = 11;
            // 
            // b_close
            // 
            this.b_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Location = new System.Drawing.Point(115, 461);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(97, 23);
            this.b_close.TabIndex = 9;
            this.b_close.Text = "Close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // pb_size
            // 
            this.pb_size.BackColor = System.Drawing.Color.Transparent;
            this.pb_size.Location = new System.Drawing.Point(12, 92);
            this.pb_size.Name = "pb_size";
            this.pb_size.Size = new System.Drawing.Size(200, 35);
            this.pb_size.TabIndex = 13;
            this.pb_size.TabStop = false;
            // 
            // pb_xy
            // 
            this.pb_xy.BackColor = System.Drawing.Color.Transparent;
            this.pb_xy.Location = new System.Drawing.Point(73, 259);
            this.pb_xy.Name = "pb_xy";
            this.pb_xy.Size = new System.Drawing.Size(139, 131);
            this.pb_xy.TabIndex = 12;
            this.pb_xy.TabStop = false;
            // 
            // pb_incline
            // 
            this.pb_incline.BackColor = System.Drawing.Color.Transparent;
            this.pb_incline.Location = new System.Drawing.Point(117, 147);
            this.pb_incline.Name = "pb_incline";
            this.pb_incline.Size = new System.Drawing.Size(95, 95);
            this.pb_incline.TabIndex = 12;
            this.pb_incline.TabStop = false;
            // 
            // pb_z
            // 
            this.pb_z.BackColor = System.Drawing.Color.Transparent;
            this.pb_z.Location = new System.Drawing.Point(12, 259);
            this.pb_z.Name = "pb_z";
            this.pb_z.Size = new System.Drawing.Size(51, 131);
            this.pb_z.TabIndex = 12;
            this.pb_z.TabStop = false;
            // 
            // pb_rotation
            // 
            this.pb_rotation.BackColor = System.Drawing.Color.Transparent;
            this.pb_rotation.Location = new System.Drawing.Point(12, 147);
            this.pb_rotation.Name = "pb_rotation";
            this.pb_rotation.Size = new System.Drawing.Size(95, 95);
            this.pb_rotation.TabIndex = 12;
            this.pb_rotation.TabStop = false;
            // 
            // b_delete
            // 
            this.b_delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete.Location = new System.Drawing.Point(10, 461);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(97, 23);
            this.b_delete.TabIndex = 9;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // ObjectSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(224, 492);
            this.Controls.Add(this.pb_size);
            this.Controls.Add(this.pb_xy);
            this.Controls.Add(this.pb_incline);
            this.Controls.Add(this.pb_z);
            this.Controls.Add(this.pb_rotation);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_default);
            this.Controls.Add(this.b_hide);
            this.Controls.Add(this.cb_hide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(240, 530);
            this.MinimumSize = new System.Drawing.Size(240, 530);
            this.Name = "ObjectSettingsForm";
            this.Text = "ObjectSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_xy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_incline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rotation)).EndInit();
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
        private System.Windows.Forms.CheckBox cb_hide;
        private System.Windows.Forms.Button b_hide;
        private System.Windows.Forms.Button b_default;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.PictureBox pb_rotation;
        private System.Windows.Forms.PictureBox pb_incline;
        private System.Windows.Forms.PictureBox pb_z;
        private System.Windows.Forms.PictureBox pb_xy;
        private System.Windows.Forms.PictureBox pb_size;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_delete;
    }
}