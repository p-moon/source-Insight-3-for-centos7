public class ContentInfo
{

	// Constructors
	public ContentInfo(byte[] content) {}
	public ContentInfo(System.Security.Cryptography.Oid contentType, byte[] content) {}

	// Methods
	public static System.Security.Cryptography.Oid GetContentType(byte[] encodedMessage) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Cryptography.Oid ContentType { get{} }
	public byte[] Content { get{} }
}

