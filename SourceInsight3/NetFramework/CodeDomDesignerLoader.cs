public class CodeDomDesignerLoader : BasicDesignerLoader, IDesignerLoaderService, INameCreationService, IDesignerSerializationService
{

	// Methods
	public virtual void Dispose() {}
	public virtual void BeginLoad(IDesignerLoaderHost host) {}
	public virtual void Flush() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Loading { get{} }
}

