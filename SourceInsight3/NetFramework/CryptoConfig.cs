public class CryptoConfig
{

	// Constructors
	public CryptoConfig() {}

	// Methods
	public static object CreateFromName(string name, object[] args) {}
	public static object CreateFromName(string name) {}
	public static string MapNameToOID(string name) {}
	public static byte[] EncodeOID(string str) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

