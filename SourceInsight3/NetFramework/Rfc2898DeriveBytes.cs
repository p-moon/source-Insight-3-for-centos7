public class Rfc2898DeriveBytes : DeriveBytes
{

	// Constructors
	public Rfc2898DeriveBytes(string password, int saltSize) {}
	public Rfc2898DeriveBytes(string password, int saltSize, int iterations) {}
	public Rfc2898DeriveBytes(string password, byte[] salt) {}
	public Rfc2898DeriveBytes(string password, byte[] salt, int iterations) {}
	public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations) {}

	// Methods
	public virtual byte[] GetBytes(int cb) {}
	public virtual void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int IterationCount { get{} set{} }
	public byte[] Salt { get{} set{} }
}

