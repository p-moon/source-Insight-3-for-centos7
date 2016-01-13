public class CodeRegionDirective : CodeDirective
{

	// Constructors
	public CodeRegionDirective() {}
	public CodeRegionDirective(CodeRegionMode regionMode, string regionText) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string RegionText { get{} set{} }
	public CodeRegionMode RegionMode { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

