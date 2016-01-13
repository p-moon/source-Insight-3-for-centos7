public class ActiveDirectorySyntax : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ActiveDirectorySyntax CaseExactString;
	public ActiveDirectorySyntax CaseIgnoreString;
	public ActiveDirectorySyntax NumericString;
	public ActiveDirectorySyntax DirectoryString;
	public ActiveDirectorySyntax OctetString;
	public ActiveDirectorySyntax SecurityDescriptor;
	public ActiveDirectorySyntax Int;
	public ActiveDirectorySyntax Int64;
	public ActiveDirectorySyntax Bool;
	public ActiveDirectorySyntax Oid;
	public ActiveDirectorySyntax GeneralizedTime;
	public ActiveDirectorySyntax UtcTime;
	public ActiveDirectorySyntax DN;
	public ActiveDirectorySyntax DNWithBinary;
	public ActiveDirectorySyntax DNWithString;
	public ActiveDirectorySyntax Enumeration;
	public ActiveDirectorySyntax IA5String;
	public ActiveDirectorySyntax PrintableString;
	public ActiveDirectorySyntax Sid;
	public ActiveDirectorySyntax AccessPointDN;
	public ActiveDirectorySyntax ORName;
	public ActiveDirectorySyntax PresentationAddress;
	public ActiveDirectorySyntax ReplicaLink;
}

