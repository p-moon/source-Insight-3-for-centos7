public class RNGCryptoServiceProvider : RandomNumberGenerator
{

	// Constructors
	public RNGCryptoServiceProvider() {}
	public RNGCryptoServiceProvider(string str) {}
	public RNGCryptoServiceProvider(byte[] rgb) {}
	public RNGCryptoServiceProvider(CspParameters cspParams) {}

	// Methods
	public virtual void GetBytes(byte[] data) {}
	public virtual void GetNonZeroBytes(byte[] data) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

