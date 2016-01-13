public class HierarchicalDataSourceView
{

	// Methods
	public abstract virtual IHierarchicalEnumerable Select() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

