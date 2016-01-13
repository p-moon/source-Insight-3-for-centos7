public class ExtensibleClassFactory
{

	// Methods
	public static void RegisterObjectCreationCallback(ObjectCreationDelegate callback) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

