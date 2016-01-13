public class WindowClass
{

	// Constructors
	public WindowClass() {}
	public WindowClass(string name, bool versioned) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public bool Versioned { get{} }
	public string XmlName { get{} set{} }
	public string XmlVersioned { get{} set{} }
}

