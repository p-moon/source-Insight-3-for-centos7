public class SinkProviderData
{

	// Constructors
	public SinkProviderData(string name) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public System.Collections.IDictionary Properties { get{} }
	public System.Collections.IList Children { get{} }
}

