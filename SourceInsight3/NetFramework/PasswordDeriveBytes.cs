public class PasswordDeriveBytes : DeriveBytes
{

	// Constructors
	public PasswordDeriveBytes(string strPassword, byte[] rgbSalt) {}
	public PasswordDeriveBytes(byte[] password, byte[] salt) {}
	public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations) {}
	public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations) {}
	public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, CspParameters cspParams) {}
	public PasswordDeriveBytes(byte[] password, byte[] salt, CspParameters cspParams) {}
	public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams) {}
	public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, CspParameters cspParams) {}

	// Methods
	public virtual byte[] GetBytes(int cb) {}
	public virtual void Reset() {}
	public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string HashName { get{} set{} }
	public int IterationCount { get{} set{} }
	public byte[] Salt { get{} set{} }
}

