public class TEXTMETRIC : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int tmHeight;
	public int tmAscent;
	public int tmDescent;
	public int tmInternalLeading;
	public int tmExternalLeading;
	public int tmAveCharWidth;
	public int tmMaxCharWidth;
	public int tmWeight;
	public int tmOverhang;
	public int tmDigitizedAspectX;
	public int tmDigitizedAspectY;
	public char tmFirstChar;
	public char tmLastChar;
	public char tmDefaultChar;
	public char tmBreakChar;
	public byte tmItalic;
	public byte tmUnderlined;
	public byte tmStruckOut;
	public byte tmPitchAndFamily;
	public byte tmCharSet;
}

