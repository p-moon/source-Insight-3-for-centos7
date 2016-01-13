public class TreeViewHitTestInfo
{

	// Constructors
	public TreeViewHitTestInfo(TreeNode hitNode, TreeViewHitTestLocations hitLocation) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TreeViewHitTestLocations Location { get{} }
	public TreeNode Node { get{} }
}

