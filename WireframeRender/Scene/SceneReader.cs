using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WireframeRender.Scene
{
    class SceneReader
    {
        string path;
        Space space;
        Object.Object curObj;
        public SceneReader(string path)
        {
            this.path = path;
        }

        public Space Read()
        {
            try
            {
                space = new Space();
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                    ProcessLine(line);
                if (curObj != null)
                    space.Objects.Add(curObj);
            }
            catch
            {
                space = null;
            }
            return space;
        }

        private void ProcessLine(string line)
        {
            string subLine = line.Substring(2);
            switch (line[0])
            {
                case 'm':
                if (curObj != null)
                    space.Objects.Add(curObj);
                    curObj = new Object.Object(subLine);
                    break;
                case 'n':
                    curObj.Name = line.Substring(2);
                    break;
                case 'x':
                    curObj.Pos.Location.X = Convert.ToDouble(subLine);
                    break;
                case 'y':
                    curObj.Pos.Location.Y = Convert.ToDouble(subLine);
                    break;
                case 'z':
                    curObj.Pos.Location.Z = Convert.ToDouble(subLine);
                    break;
                case 'r':
                    curObj.Pos.Orientation.Rotation = Convert.ToDouble(subLine);
                    break;
                case 'i':
                    curObj.Pos.Orientation.Incline = Convert.ToDouble(subLine);
                    break;
                case 's':
                    curObj.Size = Convert.ToDouble(subLine);
                    break;
                case 'h':
                    curObj.Hidden = Convert.ToBoolean(subLine);
                    break;
            }
        }
    }
}
