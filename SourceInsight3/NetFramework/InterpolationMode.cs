public class InterpolationMode : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public InterpolationMode Invalid;
	public InterpolationMode Default;
	public InterpolationMode Low;
	public InterpolationMode High;
	public InterpolationMode Bilinear;
	public InterpolationMode Bicubic;
	public InterpolationMode NearestNeighbor;
	public InterpolationMode HighQualityBilinear;
	public InterpolationMode HighQualityBicubic;
}

