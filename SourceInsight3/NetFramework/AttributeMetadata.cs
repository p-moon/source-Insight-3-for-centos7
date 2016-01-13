public class AttributeMetadata
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public int Version { get{} }
	public System.DateTime LastOriginatingChangeTime { get{} }
	public System.Guid LastOriginatingInvocationId { get{} }
	public long OriginatingChangeUsn { get{} }
	public long LocalChangeUsn { get{} }
	public string OriginatingServer { get{} }
}

