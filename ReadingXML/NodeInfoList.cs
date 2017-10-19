using System.Collections.Generic;
using System.Linq;

namespace ReadingXML
{
    internal class NodeList<T>
    {
        private readonly List<T> list;

        public NodeList()
        {
            list = new List<T>();
        }

        public T this[string name]
        {
            get
            { return list.FirstOrDefault(t => t.ToString() == name); }
        }

        public void Add(T node)
        {
            this.list.Add(node);
        }

    }
}
