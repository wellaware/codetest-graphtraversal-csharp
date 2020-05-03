using System;
using System.Linq;
using System.Collections.Generic;
using GraphTraversal.Abstractions.Models;

namespace GraphTraversal.Implementation
{
    public class GraphNode : Node
    {
        public GraphNode(string name) :
            base(name)
        {

        }

        public override IEnumerable<string> GetAttributes(Node target)
        {
            throw new NotImplementedException();
        }
    }
}
