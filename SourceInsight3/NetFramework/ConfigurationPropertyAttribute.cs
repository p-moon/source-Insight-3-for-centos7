public class ConfigurationPropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ConfigurationPropertyAttribute(string name) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} }
	public object DefaultValue { get{} set{} }
	public ConfigurationPropertyOptions Options { get{} set{} }
	public bool IsDefaultCollection { get{} set{} }
	public bool IsRequired { get{} set{} }
	public bool IsKey { get{} set{} }
	public object TypeId { get{} }
}

