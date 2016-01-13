public class AlgorithmIdentifier
{

	// Constructors
	public AlgorithmIdentifier() {}
	public AlgorithmIdentifier(System.Security.Cryptography.Oid oid) {}
	public AlgorithmIdentifier(System.Security.Cryptography.Oid oid, int keyLength) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Cryptography.Oid Oid { get{} set{} }
	public int KeyLength { get{} set{} }
	public byte[] Parameters { get{} set{} }
}

