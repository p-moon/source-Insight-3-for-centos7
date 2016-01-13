public class PartialCachingAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public PartialCachingAttribute(int duration) {}
	public PartialCachingAttribute(int duration, string varyByParams, string varyByControls, string varyByCustom) {}
	public PartialCachingAttribute(int duration, string varyByParams, string varyByControls, string varyByCustom, bool shared) {}
	public PartialCachingAttribute(int duration, string varyByParams, string varyByControls, string varyByCustom, string sqlDependency, bool shared) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int Duration { get{} }
	public string VaryByParams { get{} }
	public string VaryByControls { get{} }
	public string VaryByCustom { get{} }
	public string SqlDependency { get{} }
	public bool Shared { get{} }
	public object TypeId { get{} }
}

