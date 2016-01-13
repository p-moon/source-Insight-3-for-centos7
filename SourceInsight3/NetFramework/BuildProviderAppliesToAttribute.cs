public class BuildProviderAppliesToAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public BuildProviderAppliesToAttribute(BuildProviderAppliesTo appliesTo) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public BuildProviderAppliesTo AppliesTo { get{} }
	public object TypeId { get{} }
}

