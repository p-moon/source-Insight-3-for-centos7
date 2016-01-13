public class XmlTokenizedType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public XmlTokenizedType CDATA;
	public XmlTokenizedType ID;
	public XmlTokenizedType IDREF;
	public XmlTokenizedType IDREFS;
	public XmlTokenizedType ENTITY;
	public XmlTokenizedType ENTITIES;
	public XmlTokenizedType NMTOKEN;
	public XmlTokenizedType NMTOKENS;
	public XmlTokenizedType NOTATION;
	public XmlTokenizedType ENUMERATION;
	public XmlTokenizedType QName;
	public XmlTokenizedType NCName;
	public XmlTokenizedType None;
}

