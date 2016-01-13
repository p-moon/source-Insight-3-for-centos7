public class OutputCacheParameters
{

	// Constructors
	public OutputCacheParameters() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Enabled { get{} set{} }
	public int Duration { get{} set{} }
	public OutputCacheLocation Location { get{} set{} }
	public string VaryByCustom { get{} set{} }
	public string VaryByParam { get{} set{} }
	public string VaryByContentEncoding { get{} set{} }
	public string VaryByHeader { get{} set{} }
	public bool NoStore { get{} set{} }
	public string SqlDependency { get{} set{} }
	public string VaryByControl { get{} set{} }
	public string CacheProfile { get{} set{} }
}

