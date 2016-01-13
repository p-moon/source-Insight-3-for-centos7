public class BestFitMappingAttribute : System.Attribute, _Attribute
{

	// Constructors
	public BestFitMappingAttribute(bool BestFitMapping) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public bool ThrowOnUnmappableChar;

	// Properties
	public bool BestFitMapping { get{} }
	public object TypeId { get{} }
}

