using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GraphTraversal.Abstractions.Models;

namespace GraphTraversal.UnitTests
{
    public class TraversalTestsBase
    {
        protected Node A;
        protected Node B;
        protected Node C;
        protected Node D;
        protected Node E;
        protected Node F;
        protected Node G;
        protected Node H;
        protected Node I;
        protected Node J;

        public void InitializeTestGraph(Func<string, Node> funcCreateNode)
        {
            A = funcCreateNode("A");
            B = funcCreateNode("B");
            C = funcCreateNode("C");
            D = funcCreateNode("D");
            E = funcCreateNode("E");
            F = funcCreateNode("F");
            G = funcCreateNode("G");
            H = funcCreateNode("H");
            I = funcCreateNode("I");
            J = funcCreateNode("J");

            A.AddRange((new string[] { "a", "b" }, B), (new string[] { "b", "c", "g" }, C), (new string[] { "a", "h", "n" }, D));
            B.AddRange((new string[] { "a", "x" }, F));
            C.AddRange((new string[] { "p", "x" }, F));
            D.AddRange((new string[] { "b", "m", "n", "z" }, G));
            E.AddRange((new string[] { "q", "r", "t" }, B), (new string[] { "q", "m", "t" }, I));
            F.AddRange((new string[] { "a", "t", "x" }, E), (new string[] { "a", "b", "q" }, I), (new string[] { "u", "v", "x" }, J), (new string[] { "x", "y" }, D));
            G.AddRange((new string[] { "p", "m", "n", "c" }, F), (new string[] { "q", "t", "f", "u" }, J), (new string[] { "o", "p", "q" }, H));
            H.AddRange((new string[] { "o", "p", "n" }, D)); 
            I.AddRange((new string[] { "x", "a", "n", "f" }, J)); 
            J.AddRange((new string[] { "p", "h", "x", "j" }, H));
        }

        protected void Test_Traverse_C_to_F()
        {
            var attrs = FindAttributes(C, F);

            Assert.IsTrue(attrs.Contains("p"));
            Assert.IsTrue(attrs.Contains("x"));

            Assert.AreEqual(2, attrs.Count);
        }

        protected void Test_Traverse_A_to_F()
        {
            var attrs = FindAttributes(A, F);
            
            Assert.IsTrue(attrs.Contains("a"));
            Assert.IsTrue(attrs.Contains("b"));
            Assert.IsTrue(attrs.Contains("c"));
            Assert.IsTrue(attrs.Contains("g"));
            Assert.IsTrue(attrs.Contains("h"));
            Assert.IsTrue(attrs.Contains("m"));
            Assert.IsTrue(attrs.Contains("n"));
            Assert.IsTrue(attrs.Contains("p"));
            Assert.IsTrue(attrs.Contains("x"));
            Assert.IsTrue(attrs.Contains("z"));

            Assert.AreEqual(10, attrs.Count);
        }

        protected void Test_Traverse_A_to_J()
        {
            var attrs = FindAttributes(A, J);

            Assert.IsTrue(attrs.Contains("a"));
            Assert.IsTrue(attrs.Contains("b"));
            Assert.IsTrue(attrs.Contains("c"));
            Assert.IsTrue(attrs.Contains("f"));
            Assert.IsTrue(attrs.Contains("g"));
            Assert.IsTrue(attrs.Contains("h"));
            Assert.IsTrue(attrs.Contains("m"));
            Assert.IsTrue(attrs.Contains("n"));
            Assert.IsTrue(attrs.Contains("p"));
            Assert.IsTrue(attrs.Contains("q"));
            Assert.IsTrue(attrs.Contains("t"));
            Assert.IsTrue(attrs.Contains("u"));
            Assert.IsTrue(attrs.Contains("v"));
            Assert.IsTrue(attrs.Contains("x"));
            Assert.IsTrue(attrs.Contains("y"));
            Assert.IsTrue(attrs.Contains("z"));

            Assert.AreEqual(16, attrs.Count);
        }

        static List<string> FindAttributes(Node startNode, Node endNode)
        {
            var attrs = startNode.GetAttributes(endNode).OrderBy(a => a).ToList();

            Console.Write($"Found {attrs.Count} attributes between nodes {startNode.Name} and {endNode.Name}: ");

            if (attrs.Count > 0)
            {
                Console.WriteLine(attrs.Aggregate((a1, a2) => $"{a1}, {a2}"));
            }

            return attrs;
        }
    }
}
