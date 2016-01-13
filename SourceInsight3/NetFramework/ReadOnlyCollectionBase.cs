public class ReadOnlyCollectionBase : ICollection, IEnumerable
{

	// Methods
	public virtual IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
}

