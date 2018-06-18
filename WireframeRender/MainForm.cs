using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WireframeRender
{
    public partial class MainForm : Form
    {
        private Space space;
        private Camera.Camera mainCamera;
        private Camera.Controller camCtrl;
        private Camera.CameraSettingsForm CamSetForm;
        private List<Object.ObjectSettingsForm> ObjSetForms = new List<Object.ObjectSettingsForm>();
        private bool isLoaded;

        public MainForm()
        {
            InitializeComponent();
            SetLoad(false);
            SetNewSpace(null);
            SizeChanged += MainForm_SizeChanged;
            FormClosing += MainForm_FormClosing;
            Size = new Size(Size.Width, 750);
            //MainForm_SizeChanged(null, null);
            Read();                 
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void Read()
        {
            if (File.Exists("properties.txt"))
            {
                StreamReader sr = new StreamReader("properties.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line[0] == 's')
                        cb_scnpath.Items.Add(line.Substring(2));
                    else if (line[0] == 'o')
                        cb_objpath.Items.Add(line.Substring(2));
                }
                sr.Close();
            }
        }

        private void Save()
        {
            StreamWriter sw = new StreamWriter("properties.txt");
            foreach (string line in cb_scnpath.Items)
                sw.WriteLine("s " + line);
            foreach (string line in cb_objpath.Items)
                sw.WriteLine("o " + line);
            sw.Close();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            RefreshComponents();
        }

        private void RefreshComponents()
        {
            int dWidth = Size.Width - MinimumSize.Width;
            int dHeight = Size.Height - MinimumSize.Height;
            pb_render.Size = new Size(875+dWidth, 255+dHeight);
            b_operate.Location = new Point(614, 355+dHeight);
            b_add.Location = new Point(294, 390+dHeight);
            cb_objpath.Location = new Point(295, 321+dHeight);       
            cb_object.Location = new Point(612, 321+dHeight);           
            tb_name.Location = new Point(294, 364+dHeight);
            l_path.Location = new Point(292, 305 + dHeight);          
            l_name.Location = new Point(295, 348+dHeight);
            l_object.Location = new Point(609, 305 + dHeight);           
            cb_scnpath.Location = new Point(12, 321+dHeight);        
            b_open.Location = new Point(12, 355+dHeight);          
            b_save.Location = new Point(135, 355+dHeight);          
            b_create.Location = new Point(12, 390+dHeight);          
            b_close.Location = new Point(135, 390+dHeight);         
            l_scnPath.Location = new Point(12, 305+dHeight);
            b_cam_settings.Location = new Point(790+dWidth, 10);
            this.b_exit.Location = new Point(614, 390+dHeight);

            mainCamera.Screen = new Bitmap(pb_render.Width, pb_render.Height);
            pb_render.Image = mainCamera.Screen;
            mainCamera.Redraw();          
        }
        
        private void b_add_Click(object sender, EventArgs e)
        {
            CorrectPath(cb_objpath, ".obj");
            Object.Object obj = null;
            try
            {
                obj = new Object.Object("obj\\"+cb_objpath.Text);
            }
            catch
            {
                //Console.Beep(5000, 300);
            }

            if (obj != null)
            {
                ProcessWord(cb_objpath);
                if (tb_name.Text != "" && space.Objects.Find(someObj => (someObj.Name == tb_name.Text)) == null)
                {
                    obj.Name = tb_name.Text;
                    space.Objects.Add(obj);
                    cb_object.Items.Add(tb_name.Text);
                    cb_object.SelectedItem = tb_name.Text;
                    mainCamera.Redraw();
                }               
            }
            else if (cb_objpath.Items.Count > 0)
                cb_objpath.Items.Remove(cb_objpath.Text);
            UpdateEnability();
        }

        private void b_operate_Click(object sender, EventArgs e)
        {
            //if (cb_object.SelectedItem != null)
            //{
            Object.Object obj = space.Objects.Find(someObj => someObj.Name == cb_object.SelectedItem.ToString());
            //if (obj != null)
            //{                    
            Object.ObjectSettingsForm OSF = ObjSetForms.Find(objForm => (objForm.Object.Name == obj.Name));
            if (OSF != null)
                OSF.Focus();
            else
            {
                OSF = new Object.ObjectSettingsForm(space, obj);
                OSF.Show();
                OSF.Changed += OSF_Changed;
                OSF.PropertiesWasChanged += OSF_PropertiesWasChanged;
                OSF.FormClosed += OSF_FormClosed;
                ObjSetForms.Add(OSF);               
            }
            //}           
            //}
        }

        private void OSF_FormClosed(object sender, FormClosedEventArgs e)
        {
            ObjSetForms.Remove((Object.ObjectSettingsForm)sender);
        }

        private void OSF_PropertiesWasChanged()
        {
            UpdateObjectsList();
            UpdateEnability();
        }

        private void OSF_Changed()
        {
            mainCamera.Redraw();
        }

        private void UpdateObjectsList()
        {
            string selectedName = cb_object.Text;
            cb_object.Items.Clear();            
            foreach (Object.Object obj in space.Objects)
                cb_object.Items.Add(obj.Name);

            if (cb_object.Items.Contains(selectedName) && selectedName != null)
                cb_object.SelectedItem = selectedName;
            else if (cb_object.Items.Count > 0)
            cb_object.SelectedItem = cb_object.Items[0];
            UpdateEnability();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            //HOW CAN I USE IT ?!?!?!?!?!
        }

        private void b_cam_settings_Click(object sender, EventArgs e)
        {
            if (CamSetForm == null)
            {
                CamSetForm = new Camera.CameraSettingsForm(camCtrl);                
                CamSetForm.FormClosed += CameraSettingsForm_Closed;                
                CamSetForm.Show();                                          
            }
            else
                CamSetForm.Focus();
        }

        private void CameraSettingsForm_Closed(object sender, EventArgs e)
        {
            CamSetForm = null;
        }

        private void b_open_Click(object sender, EventArgs e)
        {
            if (cb_scnpath.Text != "")
            {
                CorrectPath(cb_scnpath, ".scn");
                if (File.Exists("scn\\" + cb_scnpath.Text))
                {
                    Scene.SceneReader sr = new Scene.SceneReader("scn\\" + cb_scnpath.Text);
                    SetNewSpace(sr.Read());
                    SetLoad(true);
                    ProcessWord(cb_scnpath);
                    UpdateObjectsList();
                }
                else if (cb_scnpath.Items.Count > 0)
                {
                    cb_scnpath.Items.Remove(cb_scnpath.Text); //если файл открыт не был, замещаем название введённого файла названием первого файла
                    if (cb_scnpath.Items.Count > 0)
                        cb_scnpath.SelectedIndex = 0;
                }
                /*{
                    if (cb_scnpath.Items.Contains(cb_scnpath.Text))
                    {
                        cb_scnpath.Items.Remove(cb_scnpath.Text);
                        if (cb_scnpath.Items.Count > 0)
                            cb_scnpath.SelectedIndex = 0;
                    }     
                }*/
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (cb_scnpath.Text != "")
            {
                CorrectPath(cb_scnpath, ".scn");
                Scene.SceneWriter sw = new Scene.SceneWriter("scn\\" + cb_scnpath.Text);
                sw.Write(space);
                ProcessWord(cb_scnpath);
            }
        }

        private void CorrectPath(ComboBox cb, string extension)
        {
            if (cb.Text != "" && !cb.Text.Contains(extension))
                    cb.Text += extension;
        }

        private void b_create_Click(object sender, EventArgs e)
        {
            SetNewSpace(new Space());          
            SetLoad(true);
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            SetNewSpace(null);
            //pb_render.Image = null;         
            mainCamera.Redraw();
            cb_object.Items.Clear();
            SetLoad(false);
                while(ObjSetForms.Count > 0)
                ObjSetForms[0].Close();
            CamSetForm?.Close();
            CamSetForm = null;
        }

        private void SetNewSpace(Space space)
        {
            camCtrl?.Dispose();
            mainCamera?.Dispose();
            this.space = space;
            mainCamera = new Camera.Camera(space);
            mainCamera.Changed += new Camera.Camera.Doing(pb_render.Refresh);
            pb_render.Image = mainCamera.Screen;
            camCtrl = new Camera.Controller(mainCamera, pb_render);
            RefreshComponents();
         }

        private void ProcessWord(ComboBox cb)
        {
            if (cb.Text != "" && !cb.Items.Contains(cb.Text))
                cb.Items.Add(cb.Text);
        }

        private void SetLoad(bool state)
        {
            isLoaded = state;
            UpdateEnability();
        }

        private void UpdateEnability()
        {
            b_add.Enabled = isLoaded;
            b_close.Enabled = isLoaded;
            b_save.Enabled = isLoaded;
            b_operate.Enabled = isLoaded;
            cb_object.Enabled = isLoaded;
            b_open.Enabled = !isLoaded;
            b_create.Enabled = !isLoaded;
            cb_object.Enabled = isLoaded && cb_object.Items.Count > 0;
            b_cam_settings.Enabled = isLoaded;
        }

        private void b_exit_Click(object sender, EventArgs e)
        {            
            Close();
        }
    }
}
