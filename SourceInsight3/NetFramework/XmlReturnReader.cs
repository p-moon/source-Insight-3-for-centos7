public class XmlReturnReader : MimeReturnReader
{

	// Constructors
	public XmlReturnReader() {}

	// Methods
	public virtual void Initialize(object o) {}
	public virtual object[] GetInitializers(LogicalMethodInfo[] methodInfos) {}
	public virtual object GetInitializer(LogicalMethodInfo methodInfo) {}
	public virtual object Read(System.Net.WebResponse response, System.IO.Stream responseStream) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

