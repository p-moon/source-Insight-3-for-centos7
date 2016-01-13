public class ReadOnlyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ReadOnlyAttribute(bool isReadOnly) {}

	// Methods
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ReadOnlyAttribute Yes;
	public ReadOnlyAttribute No;
	public ReadOnlyAttribute Default;

	// Properties
	public bool IsReadOnly { get{} }
	public object TypeId { get{} }
}

