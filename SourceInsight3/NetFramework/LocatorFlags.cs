public class LocatorFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public long value__;
	public LocatorFlags None;
	public LocatorFlags ForceRediscovery;
	public LocatorFlags DirectoryServicesRequired;
	public LocatorFlags DirectoryServicesPreferred;
	public LocatorFlags GCRequired;
	public LocatorFlags PdcRequired;
	public LocatorFlags IPRequired;
	public LocatorFlags KdcRequired;
	public LocatorFlags TimeServerRequired;
	public LocatorFlags WriteableRequired;
	public LocatorFlags GoodTimeServerPreferred;
	public LocatorFlags AvoidSelf;
	public LocatorFlags OnlyLdapNeeded;
	public LocatorFlags IsFlatName;
	public LocatorFlags IsDnsName;
	public LocatorFlags ReturnDnsName;
	public LocatorFlags ReturnFlatName;
}

