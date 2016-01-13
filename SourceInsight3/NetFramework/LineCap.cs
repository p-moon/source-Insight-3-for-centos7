public class LineCap : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public LineCap Flat;
	public LineCap Square;
	public LineCap Round;
	public LineCap Triangle;
	public LineCap NoAnchor;
	public LineCap SquareAnchor;
	public LineCap RoundAnchor;
	public LineCap DiamondAnchor;
	public LineCap ArrowAnchor;
	public LineCap Custom;
	public LineCap AnchorMask;
}

