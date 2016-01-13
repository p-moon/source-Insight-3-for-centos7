public interface IConvertible
{

	// Methods
	public abstract virtual TypeCode GetTypeCode() {}
	public abstract virtual bool ToBoolean(IFormatProvider provider) {}
	public abstract virtual char ToChar(IFormatProvider provider) {}
	public abstract virtual SByte ToSByte(IFormatProvider provider) {}
	public abstract virtual byte ToByte(IFormatProvider provider) {}
	public abstract virtual short ToInt16(IFormatProvider provider) {}
	public abstract virtual ushort ToUInt16(IFormatProvider provider) {}
	public abstract virtual int ToInt32(IFormatProvider provider) {}
	public abstract virtual uint ToUInt32(IFormatProvider provider) {}
	public abstract virtual long ToInt64(IFormatProvider provider) {}
	public abstract virtual ulong ToUInt64(IFormatProvider provider) {}
	public abstract virtual float ToSingle(IFormatProvider provider) {}
	public abstract virtual double ToDouble(IFormatProvider provider) {}
	public abstract virtual decimal ToDecimal(IFormatProvider provider) {}
	public abstract virtual DateTime ToDateTime(IFormatProvider provider) {}
	public abstract virtual string ToString(IFormatProvider provider) {}
	public abstract virtual object ToType(Type conversionType, IFormatProvider provider) {}
}

