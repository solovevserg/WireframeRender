using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WireframeRender.Scene
{
    class SceneWriter
    {
        string path;

        public SceneWriter(string path)
        {
            this.path = path;
        }

        public void Write(Space space)
        {
            StreamWriter sw = new StreamWriter(path);
            foreach (Object.Object obj in space.Objects)
            {
                sw.WriteLine("m {0}", obj.Model.Path);
                sw.WriteLine("n {0}", obj.Name);
                sw.WriteLine("x {0}", obj.Pos.Location.X);
                sw.WriteLine("y {0}", obj.Pos.Location.Y);
                sw.WriteLine("z {0}", obj.Pos.Location.Z);
                sw.WriteLine("r {0}", obj.Pos.Orientation.Rotation);
                sw.WriteLine("i {0}", obj.Pos.Orientation.Incline);
                sw.WriteLine("s {0}", obj.Size);
                sw.WriteLine("h {0}", obj.Hidden);
            }
            sw.Flush();
            sw.Close();
        }
    }
}
