using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GraphTraversal.Implementation;

namespace GraphTraversal.UnitTests
{
    [TestClass]
    public class GraphTraversalUnitTests : TraversalTestsBase
    {
        [TestInitialize]
        public void InitializeTest()
        {
            InitializeTestGraph(name => new GraphNode(name));
        }

        [TestMethod]
        public void Traverse_C_to_F()
        {
            Test_Traverse_C_to_F();
        }

        [TestMethod]
        public void Traverse_A_to_F()
        {
            Test_Traverse_A_to_F();
        }

        [TestMethod]
        public void Traverse_A_to_J()
        {
            Test_Traverse_A_to_J();
        }
    }
}
