public class EmbeddedMailObject
{

	// Constructors
	public EmbeddedMailObject() {}
	public EmbeddedMailObject(string name, string path) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public string Path { get{} set{} }
}

