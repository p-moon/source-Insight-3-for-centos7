public class VARFLAGS : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public VARFLAGS VARFLAG_FREADONLY;
	public VARFLAGS VARFLAG_FSOURCE;
	public VARFLAGS VARFLAG_FBINDABLE;
	public VARFLAGS VARFLAG_FREQUESTEDIT;
	public VARFLAGS VARFLAG_FDISPLAYBIND;
	public VARFLAGS VARFLAG_FDEFAULTBIND;
	public VARFLAGS VARFLAG_FHIDDEN;
	public VARFLAGS VARFLAG_FRESTRICTED;
	public VARFLAGS VARFLAG_FDEFAULTCOLLELEM;
	public VARFLAGS VARFLAG_FUIDEFAULT;
	public VARFLAGS VARFLAG_FNONBROWSABLE;
	public VARFLAGS VARFLAG_FREPLACEABLE;
	public VARFLAGS VARFLAG_FIMMEDIATEBIND;
}

