public class SoapExtensionReflector
{

	// Methods
	public abstract virtual void ReflectMethod() {}
	public virtual void ReflectDescription() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ProtocolReflector ReflectionContext { get{} set{} }
}

