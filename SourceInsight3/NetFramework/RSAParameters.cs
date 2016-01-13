public class RSAParameters : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public byte[] Exponent;
	public byte[] Modulus;
	public byte[] P;
	public byte[] Q;
	public byte[] DP;
	public byte[] DQ;
	public byte[] InverseQ;
	public byte[] D;
}

