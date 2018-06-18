using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WireframeRender.Model
{
    class ObjReader
    {
        private Model model;
        private string path;

        public ObjReader(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();
            this.path = path;
            model = null;
        }

        public Model Read()
        {
            model = new Model(path);
            try
            {
                ReadVertexes();
                ReadEdges();                                               
            }
            catch
            {
                model = null;
            }
            return model;
        }

        private void ReadVertexes()
        {
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
                if (IsVertex(line))
                    model.Vertexes.Add(ProcessVertex(line));
            sr.Close();
        }

        private void ReadEdges()
        {
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
                if (IsPolygon(line))
                    model.Edges.AddRange(ProcessPolygon(line));
            sr.Close();
        }

        private static Vertex ProcessVertex(string line)
        {
            Vertex vertex = new Vertex();
            List<double> vertexes = ReadNumbers(line);
            vertex.X = vertexes[0];
            vertex.Y = vertexes[1];
            vertex.Z = vertexes[2];
            return vertex;
        }

        private List<Edge> ProcessPolygon(string line)
        {
            List<Edge> edges = new List<Edge>();
            List<double> indexes = ReadNumbers(line);
            int i, j;
            Edge edge;
            for (i = 0; i < indexes.Count; i++)
            {
                j = (i + 1) % indexes.Count;
                edge = new Edge(model.Vertexes[(int)indexes[i] - 1], model.Vertexes[(int)indexes[j] - 1], (int)indexes[i] - 1, (int)indexes[j] - 1);
                if (!IsAlreadeAdded(edge))
                    edges.Add(edge);
            }
            return edges;
        }

        private bool IsAlreadeAdded(Edge edge)
        {
            bool result = false;
            for (int i = 0; i < model.Edges.Count && result; i++)
                if (edge.IsSame(model.Edges[i]))
                    result = true;
            return result;
        }
        
        private static List<double> ReadNumbers(string line)
        {
            List<double> numbers = new List<double>();
            while (line.Contains(' '))
            {
                line = line.Substring(line.IndexOf(' ') + 1);
                numbers.Add(ReadNextNumber(line));
            }
            return numbers;
        }

        private static double ReadNextNumber(string line)
        {
            int length = MinPositive(line.IndexOf(' '), line.IndexOf('/'));
            if (length < 0)
                length = line.Length;
            string number = line.Substring(0, length);
            number = number.Replace('.', ',');
            return Convert.ToDouble(number);
        }

        private static bool IsVertex(string line)
        {
            return line.StartsWith("v ");
        }

        private static bool IsPolygon(string line)
        {
            return line.StartsWith("f ");
        }

        private static int MinPositive(int a, int b)
        {
            int result = a < b ? a : b;
            if (b < 0)
                result = a;
            else if (a < 0)
                result = b;
            return result;
        }
        
    }
}
