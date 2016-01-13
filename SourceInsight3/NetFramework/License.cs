public class License : System.IDisposable
{

	// Methods
	public abstract virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string LicenseKey { get{} }
}

