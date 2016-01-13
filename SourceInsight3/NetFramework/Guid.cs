public class Guid : ValueType, IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>
{

	// Constructors
	public Guid(string g) {}
	public Guid(byte[] b) {}
	public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {}
	public Guid(int a, short b, short c, byte[] d) {}
	public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {}

	// Methods
	public virtual string ToString() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object o) {}
	public virtual bool Equals(Guid g) {}
	public virtual int CompareTo(object value) {}
	public virtual int CompareTo(Guid value) {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public byte[] ToByteArray() {}
	public static bool op_Equality(Guid a, Guid b) {}
	public static bool op_Inequality(Guid a, Guid b) {}
	public static Guid NewGuid() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public Guid Empty;
}

