namespace Tree_maximum_depth;

internal abstract class Depth
{
    private static int Dp(TreeNode? node, int maxDepth){
        return node == null ? maxDepth 
            : Math.Max(Dp(node.Left, maxDepth+1), Dp(node.Right, maxDepth+1));
    } 
    public static int MaxDepth(TreeNode? root) {
        return Dp(root, 0);
    }
}