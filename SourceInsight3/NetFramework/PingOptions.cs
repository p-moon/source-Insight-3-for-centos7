public class PingOptions
{

	// Constructors
	public PingOptions(int ttl, bool dontFragment) {}
	public PingOptions() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Ttl { get{} set{} }
	public bool DontFragment { get{} set{} }
}

