public class FormatterConverter : IFormatterConverter
{

	// Constructors
	public FormatterConverter() {}

	// Methods
	public virtual object Convert(object value, Type type) {}
	public virtual object Convert(object value, System.TypeCode typeCode) {}
	public virtual bool ToBoolean(object value) {}
	public virtual char ToChar(object value) {}
	public virtual System.SByte ToSByte(object value) {}
	public virtual byte ToByte(object value) {}
	public virtual short ToInt16(object value) {}
	public virtual ushort ToUInt16(object value) {}
	public virtual int ToInt32(object value) {}
	public virtual uint ToUInt32(object value) {}
	public virtual long ToInt64(object value) {}
	public virtual ulong ToUInt64(object value) {}
	public virtual float ToSingle(object value) {}
	public virtual double ToDouble(object value) {}
	public virtual decimal ToDecimal(object value) {}
	public virtual System.DateTime ToDateTime(object value) {}
	public virtual string ToString(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

