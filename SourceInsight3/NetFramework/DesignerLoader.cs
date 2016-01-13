public class DesignerLoader
{

	// Methods
	public abstract virtual void BeginLoad(IDesignerLoaderHost host) {}
	public abstract virtual void Dispose() {}
	public virtual void Flush() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Loading { get{} }
}

