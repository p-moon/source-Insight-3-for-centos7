public class DirectoryVirtualListView
{

	// Constructors
	public DirectoryVirtualListView() {}
	public DirectoryVirtualListView(int afterCount) {}
	public DirectoryVirtualListView(int beforeCount, int afterCount, int offset) {}
	public DirectoryVirtualListView(int beforeCount, int afterCount, string target) {}
	public DirectoryVirtualListView(int beforeCount, int afterCount, int offset, DirectoryVirtualListViewContext context) {}
	public DirectoryVirtualListView(int beforeCount, int afterCount, string target, DirectoryVirtualListViewContext context) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int BeforeCount { get{} set{} }
	public int AfterCount { get{} set{} }
	public int Offset { get{} set{} }
	public int TargetPercentage { get{} set{} }
	public string Target { get{} set{} }
	public int ApproximateTotal { get{} set{} }
	public DirectoryVirtualListViewContext DirectoryVirtualListViewContext { get{} set{} }
}

