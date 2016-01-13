public class DebugConvert : IDebugConvert, IDebugConvert2
{

	// Constructors
	public DebugConvert() {}

	// Methods
	public virtual object ToPrimitive(object value, System.TypeCode typeCode, bool truncationPermitted) {}
	public virtual string ByteToString(byte value, int radix) {}
	public virtual string SByteToString(System.SByte value, int radix) {}
	public virtual string Int16ToString(short value, int radix) {}
	public virtual string UInt16ToString(ushort value, int radix) {}
	public virtual string Int32ToString(int value, int radix) {}
	public virtual string UInt32ToString(uint value, int radix) {}
	public virtual string Int64ToString(long value, int radix) {}
	public virtual string UInt64ToString(ulong value, int radix) {}
	public virtual string SingleToString(float value) {}
	public virtual string DoubleToString(double value) {}
	public virtual string BooleanToString(bool value) {}
	public virtual string DoubleToDateString(double value) {}
	public virtual string RegexpToString(string source, bool ignoreCase, bool global, bool multiline) {}
	public virtual string DecimalToString(decimal value) {}
	public virtual string StringToPrintable(string source) {}
	public virtual object GetManagedObject(object value) {}
	public virtual object GetManagedInt64Object(long i) {}
	public virtual object GetManagedUInt64Object(ulong i) {}
	public virtual object GetManagedCharObject(ushort i) {}
	public virtual string GetErrorMessageForHR(int hr, Microsoft.Vsa.IVsaEngine engine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

