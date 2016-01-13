public class RecommendedAsConfigurableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public RecommendedAsConfigurableAttribute No;
	public RecommendedAsConfigurableAttribute Yes;
	public RecommendedAsConfigurableAttribute Default;

	// Properties
	public bool RecommendedAsConfigurable { get{} }
	public object TypeId { get{} }
}

