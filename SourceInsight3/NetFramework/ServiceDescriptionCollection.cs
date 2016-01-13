public class ServiceDescriptionCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ServiceDescriptionCollection() {}

	// Methods
	public int Add(ServiceDescription serviceDescription) {}
	public void Insert(int index, ServiceDescription serviceDescription) {}
	public int IndexOf(ServiceDescription serviceDescription) {}
	public bool Contains(ServiceDescription serviceDescription) {}
	public void Remove(ServiceDescription serviceDescription) {}
	public void CopyTo(ServiceDescription[] array, int index) {}
	public Message GetMessage(System.Xml.XmlQualifiedName name) {}
	public PortType GetPortType(System.Xml.XmlQualifiedName name) {}
	public Service GetService(System.Xml.XmlQualifiedName name) {}
	public Binding GetBinding(System.Xml.XmlQualifiedName name) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ServiceDescription Item { get{} set{} }
	public ServiceDescription Item { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

