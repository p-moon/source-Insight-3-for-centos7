public class ActiveDirectoryPartition : System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public abstract virtual System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
}

