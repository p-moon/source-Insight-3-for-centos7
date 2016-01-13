public class CipherAlgorithmType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public CipherAlgorithmType None;
	public CipherAlgorithmType Rc2;
	public CipherAlgorithmType Rc4;
	public CipherAlgorithmType Des;
	public CipherAlgorithmType TripleDes;
	public CipherAlgorithmType Aes;
	public CipherAlgorithmType Aes128;
	public CipherAlgorithmType Aes192;
	public CipherAlgorithmType Aes256;
}

