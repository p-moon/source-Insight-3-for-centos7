public class ServiceDescriptionFormatExtensionCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ServiceDescriptionFormatExtensionCollection(object parent) {}

	// Methods
	public int Add(object extension) {}
	public void Insert(int index, object extension) {}
	public int IndexOf(object extension) {}
	public bool Contains(object extension) {}
	public void Remove(object extension) {}
	public void CopyTo(object[] array, int index) {}
	public object Find(Type type) {}
	public object[] FindAll(Type type) {}
	public System.Xml.XmlElement Find(string name, string ns) {}
	public System.Xml.XmlElement[] FindAll(string name, string ns) {}
	public bool IsHandled(object item) {}
	public bool IsRequired(object item) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

