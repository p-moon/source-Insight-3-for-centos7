public class ProtectedData
{

	// Methods
	public static byte[] Protect(byte[] userData, byte[] optionalEntropy, DataProtectionScope scope) {}
	public static byte[] Unprotect(byte[] encryptedData, byte[] optionalEntropy, DataProtectionScope scope) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

