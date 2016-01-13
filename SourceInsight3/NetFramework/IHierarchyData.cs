public interface IHierarchyData
{

	// Methods
	public abstract virtual IHierarchicalEnumerable GetChildren() {}
	public abstract virtual IHierarchyData GetParent() {}

	// Properties
	public bool HasChildren { get{} }
	public string Path { get{} }
	public object Item { get{} }
	public string Type { get{} }
}

