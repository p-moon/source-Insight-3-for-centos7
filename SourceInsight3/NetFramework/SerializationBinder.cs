public class SerializationBinder
{

	// Methods
	public abstract virtual Type BindToType(string assemblyName, string typeName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

