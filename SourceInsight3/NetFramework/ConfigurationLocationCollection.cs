public class ConfigurationLocationCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ConfigurationLocation Item { get{} }
	public int Count { get{} }
}

