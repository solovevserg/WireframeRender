using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WireframeRender.Model
{
    class ObjWriter
    {
        string path;
        ObjWriter(string path)
        {
            this.path = path+".obj";
        }
        
        void Write(Model model)
        {
            StreamWriter sw = new StreamWriter(path);
            foreach (Vertex v in model.Vertexes)
                sw.WriteLine("v {0} {1} {2}", v.X, v.Y, v.Z);
            foreach (Edge e in model.Edges)
                sw.WriteLine(")
        }

    }
}
