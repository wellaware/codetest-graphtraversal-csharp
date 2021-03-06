# codetest-graphtraversal-csharp
Graph traversal coding test in C#

## Background

Refer to the classes in the code repository.

Consider a graph of interconnected **Node** objects, which contain a name and links to other **Node** objects via a list of **NodeLink** objects. A link from one node to another node contains multiple attributes that define relationships between nodes. These attributes are described as an array of strings.

For example, a very simple case is a node A with a link to node B. The link contains attributes "a", "b", and "e":

![Simple node link example](images/nodelink_simple.png)

## Problem

Implement the **GetAttributes()** method in the **GraphNode** class. This method must traverse through all paths between two nodes and accumulate all attributes while traversing on the paths that reach the target node. Any cyclic paths should be excluded from the traversal set. The returned attributes should be an accumulated set of unique attributes encountered on the various paths to the target node, with no duplicates.

A few unit tests have been provided to verify the accuracy of your implemenation. The unit test project generates a more complex graph instance in order to run traversal tests on. Feel free to add your own unit tests.

## Instructions
1. Sign into your GitHub account.
2. Navigate to this code test repository (https://github.com/wellaware/codetest-graphtraversal-csharp).
3. Click the green "Use this template" button on the repository's Code tab.
4. Give your copy of the repository a name. The same or similar name as the template repository is suggested.
5. Making your repository Public will be the easiest way to share with us. If you would prefer to keep it Private, we can arrange for you to add a WellAware account as a collaborator of your repository.
6. As described in the Problem statement, implement the **GetAttributes()** function of the **GraphNode** class in the repository.
7. When finished, send us a link to your repository to review your work.
