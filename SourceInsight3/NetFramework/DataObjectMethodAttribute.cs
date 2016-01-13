public class DataObjectMethodAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DataObjectMethodAttribute(DataObjectMethodType methodType) {}
	public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool IsDefault { get{} }
	public DataObjectMethodType MethodType { get{} }
	public object TypeId { get{} }
}

