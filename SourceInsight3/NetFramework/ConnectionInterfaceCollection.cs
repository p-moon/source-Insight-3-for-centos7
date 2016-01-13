public class ConnectionInterfaceCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ConnectionInterfaceCollection() {}
	public ConnectionInterfaceCollection(System.Collections.ICollection connectionInterfaces) {}
	public ConnectionInterfaceCollection(ConnectionInterfaceCollection existingConnectionInterfaces, System.Collections.ICollection connectionInterfaces) {}

	// Methods
	public bool Contains(Type value) {}
	public int IndexOf(Type value) {}
	public void CopyTo(Type[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public ConnectionInterfaceCollection Empty;

	// Properties
	public Type Item { get{} }
	public int Count { get{} }
}

