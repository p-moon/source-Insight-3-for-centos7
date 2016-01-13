public class GCSettings
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public GCLatencyMode LatencyMode { get{} set{} }
	public bool IsServerGC { get{} }
}

