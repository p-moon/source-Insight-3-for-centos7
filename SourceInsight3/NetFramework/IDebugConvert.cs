public interface IDebugConvert
{

	// Methods
	public abstract virtual object ToPrimitive(object value, System.TypeCode typeCode, bool truncationPermitted) {}
	public abstract virtual string ByteToString(byte value, int radix) {}
	public abstract virtual string SByteToString(System.SByte value, int radix) {}
	public abstract virtual string Int16ToString(short value, int radix) {}
	public abstract virtual string UInt16ToString(ushort value, int radix) {}
	public abstract virtual string Int32ToString(int value, int radix) {}
	public abstract virtual string UInt32ToString(uint value, int radix) {}
	public abstract virtual string Int64ToString(long value, int radix) {}
	public abstract virtual string UInt64ToString(ulong value, int radix) {}
	public abstract virtual string SingleToString(float value) {}
	public abstract virtual string DoubleToString(double value) {}
	public abstract virtual string BooleanToString(bool value) {}
	public abstract virtual string DoubleToDateString(double value) {}
	public abstract virtual string RegexpToString(string source, bool ignoreCase, bool global, bool multiline) {}
	public abstract virtual string StringToPrintable(string source) {}
	public abstract virtual object GetManagedObject(object value) {}
	public abstract virtual object GetManagedInt64Object(long i) {}
	public abstract virtual object GetManagedUInt64Object(ulong i) {}
	public abstract virtual object GetManagedCharObject(ushort i) {}
	public abstract virtual string GetErrorMessageForHR(int hr, Microsoft.Vsa.IVsaEngine engine) {}
}

