public class TreeViewEventArgs : System.EventArgs
{

	// Constructors
	public TreeViewEventArgs(TreeNode node) {}
	public TreeViewEventArgs(TreeNode node, TreeViewAction action) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TreeNode Node { get{} }
	public TreeViewAction Action { get{} }
}

