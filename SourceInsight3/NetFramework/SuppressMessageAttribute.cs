public class SuppressMessageAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SuppressMessageAttribute(string category, string checkId) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Category { get{} }
	public string CheckId { get{} }
	public string Scope { get{} set{} }
	public string Target { get{} set{} }
	public string MessageId { get{} set{} }
	public string Justification { get{} set{} }
	public object TypeId { get{} }
}

