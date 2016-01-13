public class OffsetType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public OffsetType TopLeft;
	public OffsetType TopRight;
	public OffsetType TopMiddle;
	public OffsetType BottomLeft;
	public OffsetType BottomRight;
	public OffsetType BottomMiddle;
	public OffsetType MiddleLeft;
	public OffsetType MiddleRight;
	public OffsetType LeftOfCaption;
	public OffsetType RightOfCaption;
	public OffsetType LeftOfLastButton;
	public OffsetType RightOfLastButton;
	public OffsetType AboveLastButton;
	public OffsetType BelowLastButton;
}

