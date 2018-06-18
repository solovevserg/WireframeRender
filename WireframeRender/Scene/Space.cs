using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireframeRender
{
    class Space
    {
        private List<Object.Object> objects;
        public List<Object.Object> Objects { get { return objects; } }

        public Space()
        {
            objects = new List<Object.Object>();
        }

        public void Dispose()
        {
            objects = null;            
        }
    }
}
