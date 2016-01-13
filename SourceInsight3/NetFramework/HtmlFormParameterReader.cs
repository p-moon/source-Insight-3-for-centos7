public class HtmlFormParameterReader : ValueCollectionParameterReader
{

	// Constructors
	public HtmlFormParameterReader() {}

	// Methods
	public virtual object[] Read(System.Web.HttpRequest request) {}
	public virtual void Initialize(object o) {}
	public virtual object GetInitializer(LogicalMethodInfo methodInfo) {}
	public virtual object[] GetInitializers(LogicalMethodInfo[] methodInfos) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

