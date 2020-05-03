# codetest-graphtraversal-csharp
Graph traversal coding test in C#

## Background

Refer to the classes in the code repository.

Consider a graph of interconnected **Node** objects, which contain a name and links to other **Node** objects via a list of **NodeLink** objects. A link from one node to another node contains multiple attributes that define relationships between nodes. These attributes are described as an array of strings.

For example, a very simple case is a node A with a link to node B. The link contains attributes "a", "b", and "e":

## Problem

Implement the **GetAttributes()** method in the **GraphNode** class. This method must traverse through all paths between two nodes and accumulate all attributes while traversing on the paths that reach the target node. Any cyclic paths should be excluded from the traversal set. The returned attributes should be an accumulated set of unique attributes encountered on the various paths to the target node, with no duplicates.

A few unit tests have been provided to verify the accuracy of your implemenation. Feel free to add your own unit tests.

## Instructions
