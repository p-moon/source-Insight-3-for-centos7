public class FUNCFLAGS : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public short value__;
	public FUNCFLAGS FUNCFLAG_FRESTRICTED;
	public FUNCFLAGS FUNCFLAG_FSOURCE;
	public FUNCFLAGS FUNCFLAG_FBINDABLE;
	public FUNCFLAGS FUNCFLAG_FREQUESTEDIT;
	public FUNCFLAGS FUNCFLAG_FDISPLAYBIND;
	public FUNCFLAGS FUNCFLAG_FDEFAULTBIND;
	public FUNCFLAGS FUNCFLAG_FHIDDEN;
	public FUNCFLAGS FUNCFLAG_FUSESGETLASTERROR;
	public FUNCFLAGS FUNCFLAG_FDEFAULTCOLLELEM;
	public FUNCFLAGS FUNCFLAG_FUIDEFAULT;
	public FUNCFLAGS FUNCFLAG_FNONBROWSABLE;
	public FUNCFLAGS FUNCFLAG_FREPLACEABLE;
	public FUNCFLAGS FUNCFLAG_FIMMEDIATEBIND;
}

