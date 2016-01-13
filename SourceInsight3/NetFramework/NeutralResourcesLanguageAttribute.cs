public class NeutralResourcesLanguageAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public NeutralResourcesLanguageAttribute(string cultureName) {}
	public NeutralResourcesLanguageAttribute(string cultureName, UltimateResourceFallbackLocation location) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string CultureName { get{} }
	public UltimateResourceFallbackLocation Location { get{} }
	public object TypeId { get{} }
}

