public class ProvidePropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ProvidePropertyAttribute(string propertyName, Type receiverType) {}
	public ProvidePropertyAttribute(string propertyName, string receiverTypeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string PropertyName { get{} }
	public string ReceiverTypeName { get{} }
	public object TypeId { get{} }
}

