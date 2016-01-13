public class PixelFormat : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public PixelFormat Indexed;
	public PixelFormat Gdi;
	public PixelFormat Alpha;
	public PixelFormat PAlpha;
	public PixelFormat Extended;
	public PixelFormat Canonical;
	public PixelFormat Undefined;
	public PixelFormat DontCare;
	public PixelFormat Format1bppIndexed;
	public PixelFormat Format4bppIndexed;
	public PixelFormat Format8bppIndexed;
	public PixelFormat Format16bppGrayScale;
	public PixelFormat Format16bppRgb555;
	public PixelFormat Format16bppRgb565;
	public PixelFormat Format16bppArgb1555;
	public PixelFormat Format24bppRgb;
	public PixelFormat Format32bppRgb;
	public PixelFormat Format32bppArgb;
	public PixelFormat Format32bppPArgb;
	public PixelFormat Format48bppRgb;
	public PixelFormat Format64bppArgb;
	public PixelFormat Format64bppPArgb;
	public PixelFormat Max;
}

