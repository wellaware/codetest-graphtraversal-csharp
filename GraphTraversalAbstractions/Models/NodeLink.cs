using System;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace GraphTraversal.Abstractions.Models
{
    public class NodeLink : IEquatable<NodeLink> 
    {
        public Node Link { get; }
        public string[] Attributes { get; }

        public NodeLink(string[] attributes, Node link) 
        { 
            Attributes = attributes; 
            Link = link; 
        }

        public override bool Equals(object that) => this.Equals(that as NodeLink); 
        
        public bool Equals([AllowNull] NodeLink that) => that == null ? false : this.Link == that.Link; 
        
        public override int GetHashCode() => Link.GetHashCode(); 
        
        public string AttributeStr => Attributes.Aggregate("", (r, e) => r + e);

        public override string ToString()
        {
            return $"{AttributeStr}, {Link.Name}";
        }
    }
}
