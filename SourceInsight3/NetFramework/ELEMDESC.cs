public class ELEMDESC : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public TYPEDESC tdesc;
	public DESCUNION desc;
}

