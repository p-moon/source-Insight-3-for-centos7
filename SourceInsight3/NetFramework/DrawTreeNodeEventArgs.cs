public class DrawTreeNodeEventArgs : System.EventArgs
{

	// Constructors
	public DrawTreeNodeEventArgs(System.Drawing.Graphics graphics, TreeNode node, System.Drawing.Rectangle bounds, TreeNodeStates state) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool DrawDefault { get{} set{} }
	public System.Drawing.Graphics Graphics { get{} }
	public TreeNode Node { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public TreeNodeStates State { get{} }
}

