public class MimeReturnReader : MimeFormatter
{

	// Methods
	public abstract virtual object Read(System.Net.WebResponse response, System.IO.Stream responseStream) {}
	public abstract virtual object GetInitializer(LogicalMethodInfo methodInfo) {}
	public abstract virtual void Initialize(object initializer) {}
	public virtual object[] GetInitializers(LogicalMethodInfo[] methodInfos) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

