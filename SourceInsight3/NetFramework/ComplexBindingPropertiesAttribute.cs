public class ComplexBindingPropertiesAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ComplexBindingPropertiesAttribute() {}
	public ComplexBindingPropertiesAttribute(string dataSource) {}
	public ComplexBindingPropertiesAttribute(string dataSource, string dataMember) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ComplexBindingPropertiesAttribute Default;

	// Properties
	public string DataSource { get{} }
	public string DataMember { get{} }
	public object TypeId { get{} }
}

