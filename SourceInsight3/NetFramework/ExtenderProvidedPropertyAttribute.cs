public class ExtenderProvidedPropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ExtenderProvidedPropertyAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public PropertyDescriptor ExtenderProperty { get{} }
	public IExtenderProvider Provider { get{} }
	public Type ReceiverType { get{} }
	public object TypeId { get{} }
}

