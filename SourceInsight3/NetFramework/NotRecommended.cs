public class NotRecommended : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public NotRecommended(string message) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool IsError { get{} }
	public string Message { get{} }
	public object TypeId { get{} }
}

