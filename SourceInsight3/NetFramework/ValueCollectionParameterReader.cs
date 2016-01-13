public class ValueCollectionParameterReader : MimeParameterReader
{

	// Methods
	public virtual void Initialize(object o) {}
	public virtual object GetInitializer(LogicalMethodInfo methodInfo) {}
	public static bool IsSupported(LogicalMethodInfo methodInfo) {}
	public static bool IsSupported(System.Reflection.ParameterInfo paramInfo) {}
	public abstract virtual object[] Read(System.Web.HttpRequest request) {}
	public virtual object[] GetInitializers(LogicalMethodInfo[] methodInfos) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

