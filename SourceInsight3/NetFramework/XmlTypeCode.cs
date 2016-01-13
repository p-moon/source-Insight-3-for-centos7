public class XmlTypeCode : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public XmlTypeCode None;
	public XmlTypeCode Item;
	public XmlTypeCode Node;
	public XmlTypeCode Document;
	public XmlTypeCode Element;
	public XmlTypeCode Attribute;
	public XmlTypeCode Namespace;
	public XmlTypeCode ProcessingInstruction;
	public XmlTypeCode Comment;
	public XmlTypeCode Text;
	public XmlTypeCode AnyAtomicType;
	public XmlTypeCode UntypedAtomic;
	public XmlTypeCode String;
	public XmlTypeCode Boolean;
	public XmlTypeCode Decimal;
	public XmlTypeCode Float;
	public XmlTypeCode Double;
	public XmlTypeCode Duration;
	public XmlTypeCode DateTime;
	public XmlTypeCode Time;
	public XmlTypeCode Date;
	public XmlTypeCode GYearMonth;
	public XmlTypeCode GYear;
	public XmlTypeCode GMonthDay;
	public XmlTypeCode GDay;
	public XmlTypeCode GMonth;
	public XmlTypeCode HexBinary;
	public XmlTypeCode Base64Binary;
	public XmlTypeCode AnyUri;
	public XmlTypeCode QName;
	public XmlTypeCode Notation;
	public XmlTypeCode NormalizedString;
	public XmlTypeCode Token;
	public XmlTypeCode Language;
	public XmlTypeCode NmToken;
	public XmlTypeCode Name;
	public XmlTypeCode NCName;
	public XmlTypeCode Id;
	public XmlTypeCode Idref;
	public XmlTypeCode Entity;
	public XmlTypeCode Integer;
	public XmlTypeCode NonPositiveInteger;
	public XmlTypeCode NegativeInteger;
	public XmlTypeCode Long;
	public XmlTypeCode Int;
	public XmlTypeCode Short;
	public XmlTypeCode Byte;
	public XmlTypeCode NonNegativeInteger;
	public XmlTypeCode UnsignedLong;
	public XmlTypeCode UnsignedInt;
	public XmlTypeCode UnsignedShort;
	public XmlTypeCode UnsignedByte;
	public XmlTypeCode PositiveInteger;
	public XmlTypeCode YearMonthDuration;
	public XmlTypeCode DayTimeDuration;
}

