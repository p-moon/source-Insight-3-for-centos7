public class TreeViewCancelEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public TreeViewCancelEventArgs(TreeNode node, bool cancel, TreeViewAction action) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TreeNode Node { get{} }
	public TreeViewAction Action { get{} }
	public bool Cancel { get{} set{} }
}

