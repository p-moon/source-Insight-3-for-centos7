public interface IFormatterConverter
{

	// Methods
	public abstract virtual object Convert(object value, Type type) {}
	public abstract virtual object Convert(object value, System.TypeCode typeCode) {}
	public abstract virtual bool ToBoolean(object value) {}
	public abstract virtual char ToChar(object value) {}
	public abstract virtual System.SByte ToSByte(object value) {}
	public abstract virtual byte ToByte(object value) {}
	public abstract virtual short ToInt16(object value) {}
	public abstract virtual ushort ToUInt16(object value) {}
	public abstract virtual int ToInt32(object value) {}
	public abstract virtual uint ToUInt32(object value) {}
	public abstract virtual long ToInt64(object value) {}
	public abstract virtual ulong ToUInt64(object value) {}
	public abstract virtual float ToSingle(object value) {}
	public abstract virtual double ToDouble(object value) {}
	public abstract virtual decimal ToDecimal(object value) {}
	public abstract virtual System.DateTime ToDateTime(object value) {}
	public abstract virtual string ToString(object value) {}
}

