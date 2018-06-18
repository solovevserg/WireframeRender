using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireframeRender.Model
{
    class Model
    {
        private List<Vertex> vertexes;
        public List<Vertex> Vertexes
        {
            get
            {
                return vertexes;
            }
        }

        private List<Edge> edges;
        public List<Edge> Edges
        {
            get
            {
                return edges;
            }
        }

        private readonly string path;
        public string Path
        {
            get
            {
                return path;
            }
        }

        public Model(string path = null)
        {
            this.path = path;
            vertexes = new List<Vertex>();
            edges = new List<Edge>();
        }
    }
}
