public class BulletStyle : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public BulletStyle NotSet;
	public BulletStyle Numbered;
	public BulletStyle LowerAlpha;
	public BulletStyle UpperAlpha;
	public BulletStyle LowerRoman;
	public BulletStyle UpperRoman;
	public BulletStyle Disc;
	public BulletStyle Circle;
	public BulletStyle Square;
	public BulletStyle CustomImage;
}

