public class MimeFormatter
{

	// Methods
	public abstract virtual object GetInitializer(LogicalMethodInfo methodInfo) {}
	public abstract virtual void Initialize(object initializer) {}
	public virtual object[] GetInitializers(LogicalMethodInfo[] methodInfos) {}
	public static object GetInitializer(Type type, LogicalMethodInfo methodInfo) {}
	public static object[] GetInitializers(Type type, LogicalMethodInfo[] methodInfos) {}
	public static MimeFormatter CreateInstance(Type type, object initializer) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

