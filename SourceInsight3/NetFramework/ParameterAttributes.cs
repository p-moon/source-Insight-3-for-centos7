public class ParameterAttributes : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ParameterAttributes None;
	public ParameterAttributes In;
	public ParameterAttributes Out;
	public ParameterAttributes Lcid;
	public ParameterAttributes Retval;
	public ParameterAttributes Optional;
	public ParameterAttributes ReservedMask;
	public ParameterAttributes HasDefault;
	public ParameterAttributes HasFieldMarshal;
	public ParameterAttributes Reserved3;
	public ParameterAttributes Reserved4;
}

