public class SoapExtensionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type ExtensionType { get{} }
	public int Priority { get{} set{} }
	public object TypeId { get{} }
}

