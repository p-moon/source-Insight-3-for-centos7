public class RandomNumberGenerator
{

	// Methods
	public static RandomNumberGenerator Create() {}
	public static RandomNumberGenerator Create(string rngName) {}
	public abstract virtual void GetBytes(byte[] data) {}
	public abstract virtual void GetNonZeroBytes(byte[] data) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

