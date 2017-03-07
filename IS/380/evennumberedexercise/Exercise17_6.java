public class Exercise17_6 {
  public static void main(String[] args) {
    BinaryTree tree = new BinaryTree(new String[] {
      "Tom", "George", "Jean", "Jane", "Kevin"});

    tree.inorder();
    System.out.println(tree.depth());
  }
}

// BinaryTree.java: Add three new methods in this exercise
class BinaryTree {
  private TreeNode root;

  /** Create a default binary tree */
  public BinaryTree() {
  }

  /** Create a binary tree from an array of objects */
  public BinaryTree(Object[] objects) {
    for (int i = 0; i < objects.length; i++)
      insert(objects[i]);
  }

  /** Search element o in this binary tree */
  public boolean search(Object o) {
    return search(o, root);
  }

  public boolean search(Object o, TreeNode root) {
    if (root == null) return false;
    if (root.element.equals(o)) return true;
    else return search(o, root.left) || search(o, root.right);
  }

  /** Return the number of nodes in this binary tree */
  public int size() {
    return size(root);
  }

  public int size(TreeNode root) {
    if (root == null) return 0;
    else return 1 + size(root.left) + size(root.right);
  }

  /** Return the depth of this binary tree. Depth is the
    * number of the nodes in the longest path of the tree */
  public int depth() {
    return depth(root);
  }

  public int depth(TreeNode root) {
    if (root == null) return 0;
    else return 1 + Math.max(depth(root.left), depth(root.right));
  }

  /** Insert element o into the binary tree
   * Return true if the element is inserted successfully */
  public boolean insert(Object o) {
    if (root == null)
      root = new TreeNode(o); // Create a new root
    else {
      // Locate the parent node
      TreeNode parent = null;
      TreeNode current = root;
      while (current != null)
        if (((Comparable)o).compareTo(current.element) < 0) {
          parent = current;
          current = current.left;
        }
        else if (((Comparable)o).compareTo(current.element) > 0) {
          parent = current;
          current = current.right;
        }
        else
          return false; // Duplicate node not inserted

      // Create the new node and attach it to the parent node
      if (((Comparable)o).compareTo(parent.element) < 0)
        parent.left = new TreeNode(o);
      else
        parent.right = new TreeNode(o);
    }

    return true; // Element inserted
  }

  /** Inorder traversal */
  public void inorder() {
    inorder(root);
  }

  /** Inorder traversal from a subtree */
  private void inorder(TreeNode root) {
    if (root == null) return;
    inorder(root.left);
    System.out.print(root.element + " ");
    inorder(root.right);
  }

  /** Postorder traversal */
  public void postorder() {
    postorder(root);
  }

  /** Postorder traversal from a subtree */
  private void postorder(TreeNode root) {
    if (root == null) return;
    postorder(root.left);
    postorder(root.right);
    System.out.print(root.element + " ");
  }

  /** Preorder traversal */
  public void preorder() {
    preorder(root);
  }

  /** Preorder traversal from a subtree */
  private void preorder(TreeNode root) {
    if (root == null) return;
    System.out.print(root.element + " ");
    preorder(root.left);
    preorder(root.right);
  }

  /** Inner class tree node */
  private class TreeNode {
    Object element;
    TreeNode left;
    TreeNode right;

    public TreeNode(Object o) {
      element = o;
    }
  }
}
