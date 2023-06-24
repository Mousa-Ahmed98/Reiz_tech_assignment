using Tree_maximum_depth;

TreeNode node1 = new TreeNode(3, new TreeNode(4, null, null), new TreeNode(0, new TreeNode(89, null, null), null));

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Maximum depth = {Depth.MaxDepth(node1)}");