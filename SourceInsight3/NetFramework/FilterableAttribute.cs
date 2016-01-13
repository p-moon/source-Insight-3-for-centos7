public class FilterableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public FilterableAttribute(bool filterable) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public static bool IsObjectFilterable(object instance) {}
	public static bool IsPropertyFilterable(System.ComponentModel.PropertyDescriptor propertyDescriptor) {}
	public static bool IsTypeFilterable(Type type) {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public FilterableAttribute Yes;
	public FilterableAttribute No;
	public FilterableAttribute Default;

	// Properties
	public bool Filterable { get{} }
	public object TypeId { get{} }
}

