public interface IHierarchicalEnumerable : System.Collections.IEnumerable
{

	// Methods
	public abstract virtual IHierarchyData GetHierarchyData(object enumeratedItem) {}
}

