public class SerializationStore : System.IDisposable
{

	// Methods
	public abstract virtual void Close() {}
	public abstract virtual void Save(System.IO.Stream stream) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ICollection Errors { get{} }
}

