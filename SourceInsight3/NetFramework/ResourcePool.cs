public class ResourcePool : IObjPool
{

	// Constructors
	public ResourcePool(TransactionEndDelegate cb) {}

	// Methods
	public bool PutResource(object resource) {}
	public object GetResource() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

