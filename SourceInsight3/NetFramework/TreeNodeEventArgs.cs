public class TreeNodeEventArgs : System.EventArgs
{

	// Constructors
	public TreeNodeEventArgs(TreeNode node) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TreeNode Node { get{} }
}

