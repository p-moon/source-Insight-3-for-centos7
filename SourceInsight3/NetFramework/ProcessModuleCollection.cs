public class ProcessModuleCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ProcessModuleCollection(ProcessModule[] processModules) {}

	// Methods
	public int IndexOf(ProcessModule module) {}
	public bool Contains(ProcessModule module) {}
	public void CopyTo(ProcessModule[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ProcessModule Item { get{} }
	public int Count { get{} }
}

