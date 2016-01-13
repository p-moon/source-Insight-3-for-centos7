public class NodeLabelEditEventArgs : System.EventArgs
{

	// Constructors
	public NodeLabelEditEventArgs(TreeNode node) {}
	public NodeLabelEditEventArgs(TreeNode node, string label) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CancelEdit { get{} set{} }
	public string Label { get{} }
	public TreeNode Node { get{} }
}

