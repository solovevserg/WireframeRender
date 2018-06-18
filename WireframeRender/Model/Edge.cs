using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireframeRender.Model
{
    class Edge
    {
        public Vertex A { get; set; }
        public Vertex B { get; set; }

        public int AIndex { get; set; }
        public int BIndex { get; set; }
        
        public Edge(Vertex AIn, Vertex BIn)
        {
            Set(AIn, BIn);
        }

        public Edge(Vertex AIn, Vertex BIn, int aIndexIn, int bIndexIn)
        {
            Set(AIn, BIn);
            SetIndexes(aIndexIn, bIndexIn);
        }

        public void SetIndexes(int aIndexIn, int bIndexIn)
        {
            AIndex = aIndexIn;
            BIndex = bIndexIn;
        }

        Edge() //нужно ли?
        {
            Set(null, null);
        }

        public bool Set(Vertex AIn, Vertex BIn)
        {
            A = AIn;
            B = BIn;
            return !A.Equals(null) && !B.Equals(null);
        }

        public bool IsSame(Edge that)
        {
            return this.AIndex == that.AIndex && this.BIndex == that.BIndex;
        }
    }
}
