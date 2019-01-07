// binary search tree basics

class TreeNode
{
    // properties data, left, right
    int data;
    TreeNode left, right = null;
    // constructor for new tree node
    public TreeNode(int d)
    {
        data = d;
    }
    // add new node
    public TreeNode insertNode(TreeNode root, int d)
    {
        // if tree empty, set new node
        if (root == null)
        {
            root = new TreeNode(d);
        }
        // else recurse down tree
        // if data less than node key, recurse left tree
        else if (d < root.data)
        {
            root.left = insertNode(root.left, d);
        }
        // else recurse right tree
        else
        {
            root.right = insertNode(root.right, d);
        }
        // return new tree
        return root;
    }

    // searching node in tree
    public TreeNode searchNode(TreeNode root, int d)
    {
        // if data is current node, return node
        if(root.data == d)
        {
            return root;
        }
        // if data is less that current root, traverse down left tree
        if (d < root.data)
        {
            searchNode(root.left, d);
        }
        // else traverse right tree
        else
        {
            searchNode(root.right, d);
        }
    }
}