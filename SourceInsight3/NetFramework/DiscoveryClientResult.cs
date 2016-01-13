public class DiscoveryClientResult
{

	// Constructors
	public DiscoveryClientResult() {}
	public DiscoveryClientResult(Type referenceType, string url, string filename) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ReferenceTypeName { get{} set{} }
	public string Url { get{} set{} }
	public string Filename { get{} set{} }
}

