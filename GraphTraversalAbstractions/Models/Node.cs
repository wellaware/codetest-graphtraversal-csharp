using System;
using System.Linq;
using System.Collections.Generic;


namespace GraphTraversal.Abstractions.Models
{
    public abstract class Node
    {
        protected List<NodeLink> _links = new List<NodeLink>();

        public string Name { get; }
        public IEnumerable<NodeLink> Links => _links;

        public Node(string name)
        {
            Name = name;
        }

        public Node Add(NodeLink link) 
        { 
            _links.Add(link); 
            return this; 
        }

        public Node AddRange(IEnumerable<NodeLink> links)
        {
            _links.AddRange(links); 
            return this;
        }

        public Node AddRange(params (IEnumerable<string> attrs, Node node)[] links) 
        { 
            _links.AddRange(links.Select(x => new NodeLink(x.attrs.ToArray(), x.node))); 
            _links = _links.Distinct().ToList(); 
            return this; 
        }

        public Node Clear() 
        { 
            _links.Clear(); 
            return this; 
        }

        public override string ToString()
        {
            return Name;
        }


        public abstract IEnumerable<string> GetAttributes(Node target);
    }
}
