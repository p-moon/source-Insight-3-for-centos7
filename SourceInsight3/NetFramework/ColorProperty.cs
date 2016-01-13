public class ColorProperty : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ColorProperty BorderColor;
	public ColorProperty FillColor;
	public ColorProperty TextColor;
	public ColorProperty EdgeLightColor;
	public ColorProperty EdgeHighlightColor;
	public ColorProperty EdgeShadowColor;
	public ColorProperty EdgeDarkShadowColor;
	public ColorProperty EdgeFillColor;
	public ColorProperty TransparentColor;
	public ColorProperty GradientColor1;
	public ColorProperty GradientColor2;
	public ColorProperty GradientColor3;
	public ColorProperty GradientColor4;
	public ColorProperty GradientColor5;
	public ColorProperty ShadowColor;
	public ColorProperty GlowColor;
	public ColorProperty TextBorderColor;
	public ColorProperty TextShadowColor;
	public ColorProperty GlyphTextColor;
	public ColorProperty GlyphTransparentColor;
	public ColorProperty FillColorHint;
	public ColorProperty BorderColorHint;
	public ColorProperty AccentColorHint;
}

