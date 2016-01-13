public class PublicKeyInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AlgorithmIdentifier Algorithm { get{} }
	public byte[] KeyValue { get{} }
}

