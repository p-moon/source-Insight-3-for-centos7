public class DefaultDependencyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DefaultDependencyAttribute(LoadHint loadHintArgument) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public LoadHint LoadHint { get{} }
	public object TypeId { get{} }
}

