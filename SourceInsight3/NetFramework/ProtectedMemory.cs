public class ProtectedMemory
{

	// Methods
	public static void Protect(byte[] userData, MemoryProtectionScope scope) {}
	public static void Unprotect(byte[] encryptedData, MemoryProtectionScope scope) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

