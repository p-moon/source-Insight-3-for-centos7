public class ComSourceInterfacesAttribute : System.Attribute, _Attribute
{

	// Constructors
	public ComSourceInterfacesAttribute(string sourceInterfaces) {}
	public ComSourceInterfacesAttribute(Type sourceInterface) {}
	public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2) {}
	public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3) {}
	public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3, Type sourceInterface4) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Value { get{} }
	public object TypeId { get{} }
}

