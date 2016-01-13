public class BooleanProperty : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public BooleanProperty Transparent;
	public BooleanProperty AutoSize;
	public BooleanProperty BorderOnly;
	public BooleanProperty Composited;
	public BooleanProperty BackgroundFill;
	public BooleanProperty GlyphTransparent;
	public BooleanProperty GlyphOnly;
	public BooleanProperty AlwaysShowSizingBar;
	public BooleanProperty MirrorImage;
	public BooleanProperty UniformSizing;
	public BooleanProperty IntegralSizing;
	public BooleanProperty SourceGrow;
	public BooleanProperty SourceShrink;
}

