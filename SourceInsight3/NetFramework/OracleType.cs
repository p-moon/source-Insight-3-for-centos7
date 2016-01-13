public class OracleType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public OracleType BFile;
	public OracleType Blob;
	public OracleType Char;
	public OracleType Clob;
	public OracleType Cursor;
	public OracleType DateTime;
	public OracleType IntervalDayToSecond;
	public OracleType IntervalYearToMonth;
	public OracleType LongRaw;
	public OracleType LongVarChar;
	public OracleType NChar;
	public OracleType NClob;
	public OracleType Number;
	public OracleType NVarChar;
	public OracleType Raw;
	public OracleType RowId;
	public OracleType Timestamp;
	public OracleType TimestampLocal;
	public OracleType TimestampWithTZ;
	public OracleType VarChar;
	public OracleType Byte;
	public OracleType UInt16;
	public OracleType UInt32;
	public OracleType SByte;
	public OracleType Int16;
	public OracleType Int32;
	public OracleType Float;
	public OracleType Double;
}

