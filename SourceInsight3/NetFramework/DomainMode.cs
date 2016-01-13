public class DomainMode : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public DomainMode Windows2000MixedDomain;
	public DomainMode Windows2000NativeDomain;
	public DomainMode Windows2003InterimDomain;
	public DomainMode Windows2003Domain;
	public DomainMode Windows2008Domain;
}

