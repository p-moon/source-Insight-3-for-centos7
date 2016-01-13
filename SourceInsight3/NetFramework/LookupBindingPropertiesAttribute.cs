public class LookupBindingPropertiesAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public LookupBindingPropertiesAttribute() {}
	public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public LookupBindingPropertiesAttribute Default;

	// Properties
	public string DataSource { get{} }
	public string DisplayMember { get{} }
	public string ValueMember { get{} }
	public string LookupMember { get{} }
	public object TypeId { get{} }
}

