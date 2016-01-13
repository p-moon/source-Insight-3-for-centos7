public class NopReturnReader : MimeReturnReader
{

	// Constructors
	public NopReturnReader() {}

	// Methods
	public virtual object GetInitializer(LogicalMethodInfo methodInfo) {}
	public virtual void Initialize(object initializer) {}
	public virtual object Read(System.Net.WebResponse response, System.IO.Stream responseStream) {}
	public virtual object[] GetInitializers(LogicalMethodInfo[] methodInfos) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

