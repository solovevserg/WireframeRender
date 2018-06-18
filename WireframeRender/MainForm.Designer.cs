namespace WireframeRender
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.b_operate = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.cb_objpath = new System.Windows.Forms.ComboBox();
            this.cb_object = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.l_path = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.l_object = new System.Windows.Forms.Label();
            this.b_open = new System.Windows.Forms.Button();
            this.cb_scnpath = new System.Windows.Forms.ComboBox();
            this.b_save = new System.Windows.Forms.Button();
            this.b_create = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.l_scnPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.b_cam_settings = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.pb_render = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_render)).BeginInit();
            this.SuspendLayout();
            // 
            // b_operate
            // 
            this.b_operate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_operate.Location = new System.Drawing.Point(614, 355);
            this.b_operate.Name = "b_operate";
            this.b_operate.Size = new System.Drawing.Size(273, 23);
            this.b_operate.TabIndex = 1;
            this.b_operate.Text = "Operate";
            this.b_operate.UseVisualStyleBackColor = true;
            this.b_operate.Click += new System.EventHandler(this.b_operate_Click);
            // 
            // b_add
            // 
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.Location = new System.Drawing.Point(294, 390);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(275, 23);
            this.b_add.TabIndex = 1;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // cb_objpath
            // 
            this.cb_objpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_objpath.FormattingEnabled = true;
            this.cb_objpath.Location = new System.Drawing.Point(295, 321);
            this.cb_objpath.Name = "cb_objpath";
            this.cb_objpath.Size = new System.Drawing.Size(275, 21);
            this.cb_objpath.TabIndex = 4;
            // 
            // cb_object
            // 
            this.cb_object.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_object.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_object.FormattingEnabled = true;
            this.cb_object.Location = new System.Drawing.Point(614, 321);
            this.cb_object.Name = "cb_object";
            this.cb_object.Size = new System.Drawing.Size(273, 21);
            this.cb_object.TabIndex = 4;
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Location = new System.Drawing.Point(294, 364);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(275, 20);
            this.tb_name.TabIndex = 5;
            // 
            // l_path
            // 
            this.l_path.AutoSize = true;
            this.l_path.Location = new System.Drawing.Point(292, 305);
            this.l_path.Name = "l_path";
            this.l_path.Size = new System.Drawing.Size(265, 13);
            this.l_path.TabIndex = 6;
            this.l_path.Text = "Choose the .obj file from the list below or enter the path";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(295, 348);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(160, 13);
            this.l_name.TabIndex = 7;
            this.l_name.Text = "Give the name to the new model";
            // 
            // l_object
            // 
            this.l_object.AutoSize = true;
            this.l_object.Location = new System.Drawing.Point(609, 305);
            this.l_object.Name = "l_object";
            this.l_object.Size = new System.Drawing.Size(131, 13);
            this.l_object.TabIndex = 8;
            this.l_object.Text = "Choose the object to work";
            // 
            // b_open
            // 
            this.b_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_open.Location = new System.Drawing.Point(12, 355);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(106, 23);
            this.b_open.TabIndex = 11;
            this.b_open.Text = "Open";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // cb_scnpath
            // 
            this.cb_scnpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_scnpath.FormattingEnabled = true;
            this.cb_scnpath.Location = new System.Drawing.Point(12, 321);
            this.cb_scnpath.Name = "cb_scnpath";
            this.cb_scnpath.Size = new System.Drawing.Size(236, 21);
            this.cb_scnpath.TabIndex = 4;
            // 
            // b_save
            // 
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Location = new System.Drawing.Point(135, 390);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(113, 23);
            this.b_save.TabIndex = 11;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_create
            // 
            this.b_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_create.Location = new System.Drawing.Point(12, 390);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(106, 23);
            this.b_create.TabIndex = 11;
            this.b_create.Text = "Create";
            this.b_create.UseVisualStyleBackColor = true;
            this.b_create.Click += new System.EventHandler(this.b_create_Click);
            // 
            // b_close
            // 
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Location = new System.Drawing.Point(135, 355);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(113, 23);
            this.b_close.TabIndex = 11;
            this.b_close.Text = "Close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // l_scnPath
            // 
            this.l_scnPath.AutoSize = true;
            this.l_scnPath.Location = new System.Drawing.Point(12, 305);
            this.l_scnPath.Name = "l_scnPath";
            this.l_scnPath.Size = new System.Drawing.Size(138, 13);
            this.l_scnPath.TabIndex = 6;
            this.l_scnPath.Text = "Enter the project name here";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "fgh";
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // b_cam_settings
            // 
            this.b_cam_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cam_settings.Location = new System.Drawing.Point(790, 10);
            this.b_cam_settings.Name = "b_cam_settings";
            this.b_cam_settings.Size = new System.Drawing.Size(97, 23);
            this.b_cam_settings.TabIndex = 12;
            this.b_cam_settings.Text = "Camera settings";
            this.b_cam_settings.UseVisualStyleBackColor = true;
            this.b_cam_settings.Click += new System.EventHandler(this.b_cam_settings_Click);
            // 
            // b_exit
            // 
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.Location = new System.Drawing.Point(614, 390);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(273, 23);
            this.b_exit.TabIndex = 1;
            this.b_exit.Text = "Exit";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // pb_render
            // 
            this.pb_render.BackColor = System.Drawing.Color.White;
            this.pb_render.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_render.InitialImage = global::WireframeRender.Properties.Resources.Background2;
            this.pb_render.Location = new System.Drawing.Point(12, 39);
            this.pb_render.Name = "pb_render";
            this.pb_render.Size = new System.Drawing.Size(875, 255);
            this.pb_render.TabIndex = 0;
            this.pb_render.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(899, 437);
            this.Controls.Add(this.b_cam_settings);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_create);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_open);
            this.Controls.Add(this.l_object);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.l_scnPath);
            this.Controls.Add(this.l_path);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.cb_object);
            this.Controls.Add(this.cb_scnpath);
            this.Controls.Add(this.cb_objpath);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_operate);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.pb_render);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(915, 475);
            this.Name = "MainForm";
            this.Text = "Wireframe Render";
            ((System.ComponentModel.ISupportInitialize)(this.pb_render)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_render;
        private System.Windows.Forms.Button b_operate;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.ComboBox cb_objpath;
        private System.Windows.Forms.ComboBox cb_object;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label l_path;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_object;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.ComboBox cb_scnpath;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_create;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Label l_scnPath;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button b_cam_settings;
        private System.Windows.Forms.Button b_exit;
    }
}

