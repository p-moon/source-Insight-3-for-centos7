public class ImageFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ImageFlags None;
	public ImageFlags Scalable;
	public ImageFlags HasAlpha;
	public ImageFlags HasTranslucent;
	public ImageFlags PartiallyScalable;
	public ImageFlags ColorSpaceRgb;
	public ImageFlags ColorSpaceCmyk;
	public ImageFlags ColorSpaceGray;
	public ImageFlags ColorSpaceYcbcr;
	public ImageFlags ColorSpaceYcck;
	public ImageFlags HasRealDpi;
	public ImageFlags HasRealPixelSize;
	public ImageFlags ReadOnly;
	public ImageFlags Caching;
}

