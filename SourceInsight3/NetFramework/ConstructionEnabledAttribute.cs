public class ConstructionEnabledAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IConfigurationAttribute
{

	// Constructors
	public ConstructionEnabledAttribute() {}
	public ConstructionEnabledAttribute(bool val) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Default { get{} set{} }
	public bool Enabled { get{} set{} }
	public object TypeId { get{} }
}

