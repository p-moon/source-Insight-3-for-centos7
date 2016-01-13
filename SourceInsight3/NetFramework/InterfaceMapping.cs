public class InterfaceMapping : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public Type TargetType;
	public Type InterfaceType;
	public MethodInfo[] TargetMethods;
	public MethodInfo[] InterfaceMethods;
}

