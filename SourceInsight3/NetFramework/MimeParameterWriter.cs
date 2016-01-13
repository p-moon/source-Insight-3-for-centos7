public class MimeParameterWriter : MimeFormatter
{

	// Methods
	public virtual string GetRequestUrl(string url, object[] parameters) {}
	public virtual void InitializeRequest(System.Net.WebRequest request, object[] values) {}
	public virtual void WriteRequest(System.IO.Stream requestStream, object[] values) {}
	public abstract virtual object GetInitializer(LogicalMethodInfo methodInfo) {}
	public abstract virtual void Initialize(object initializer) {}
	public virtual object[] GetInitializers(LogicalMethodInfo[] methodInfos) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UsesWriteRequest { get{} }
	public System.Text.Encoding RequestEncoding { get{} set{} }
}

