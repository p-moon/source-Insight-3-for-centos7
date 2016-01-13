public class RequestCachePolicy
{

	// Constructors
	public RequestCachePolicy() {}
	public RequestCachePolicy(RequestCacheLevel level) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RequestCacheLevel Level { get{} }
}

