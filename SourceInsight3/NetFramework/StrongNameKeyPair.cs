public class StrongNameKeyPair : System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public StrongNameKeyPair(System.IO.FileStream keyPairFile) {}
	public StrongNameKeyPair(byte[] keyPairArray) {}
	public StrongNameKeyPair(string keyPairContainer) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public byte[] PublicKey { get{} }
}

