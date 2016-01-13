public class XmlNodeType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public XmlNodeType None;
	public XmlNodeType Element;
	public XmlNodeType Attribute;
	public XmlNodeType Text;
	public XmlNodeType CDATA;
	public XmlNodeType EntityReference;
	public XmlNodeType Entity;
	public XmlNodeType ProcessingInstruction;
	public XmlNodeType Comment;
	public XmlNodeType Document;
	public XmlNodeType DocumentType;
	public XmlNodeType DocumentFragment;
	public XmlNodeType Notation;
	public XmlNodeType Whitespace;
	public XmlNodeType SignificantWhitespace;
	public XmlNodeType EndElement;
	public XmlNodeType EndEntity;
	public XmlNodeType XmlDeclaration;
}

