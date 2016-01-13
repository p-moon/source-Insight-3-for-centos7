public class DSAParameters : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public byte[] P;
	public byte[] Q;
	public byte[] G;
	public byte[] Y;
	public byte[] J;
	public byte[] X;
	public byte[] Seed;
	public int Counter;
}

