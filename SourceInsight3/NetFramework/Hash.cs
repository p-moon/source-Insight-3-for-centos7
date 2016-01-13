public class Hash : System.Runtime.Serialization.ISerializable, IBuiltInEvidence
{

	// Constructors
	public Hash(System.Reflection.Assembly assembly) {}

	// Methods
	public static Hash CreateSHA1(byte[] sha1) {}
	public static Hash CreateMD5(byte[] md5) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public byte[] GenerateHash(System.Security.Cryptography.HashAlgorithm hashAlg) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public byte[] SHA1 { get{} }
	public byte[] MD5 { get{} }
}

