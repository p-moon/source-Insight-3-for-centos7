public class SchemaImporterExtensionCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SchemaImporterExtensionCollection() {}

	// Methods
	public int Add(SchemaImporterExtension extension) {}
	public int Add(string name, Type type) {}
	public void Remove(string name) {}
	public void Clear() {}
	public void Insert(int index, SchemaImporterExtension extension) {}
	public int IndexOf(SchemaImporterExtension extension) {}
	public bool Contains(SchemaImporterExtension extension) {}
	public void Remove(SchemaImporterExtension extension) {}
	public void CopyTo(SchemaImporterExtension[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SchemaImporterExtension Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

