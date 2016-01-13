public class ObsoleteAttribute : Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ObsoleteAttribute() {}
	public ObsoleteAttribute(string message) {}
	public ObsoleteAttribute(string message, bool error) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Message { get{} }
	public bool IsError { get{} }
	public object TypeId { get{} }
}

