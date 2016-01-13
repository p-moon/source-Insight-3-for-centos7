public class TreeNodeMouseHoverEventArgs : System.EventArgs
{

	// Constructors
	public TreeNodeMouseHoverEventArgs(TreeNode node) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TreeNode Node { get{} }
}

