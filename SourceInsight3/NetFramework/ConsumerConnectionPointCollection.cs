public class ConsumerConnectionPointCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ConsumerConnectionPointCollection() {}
	public ConsumerConnectionPointCollection(System.Collections.ICollection connectionPoints) {}

	// Methods
	public bool Contains(ConsumerConnectionPoint connectionPoint) {}
	public int IndexOf(ConsumerConnectionPoint connectionPoint) {}
	public void CopyTo(ConsumerConnectionPoint[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ConsumerConnectionPoint Default { get{} }
	public ConsumerConnectionPoint Item { get{} }
	public ConsumerConnectionPoint Item { get{} }
	public int Count { get{} }
}

