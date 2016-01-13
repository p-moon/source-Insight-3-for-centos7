public class TextFormatFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TextFormatFlags Bottom;
	public TextFormatFlags EndEllipsis;
	public TextFormatFlags ExpandTabs;
	public TextFormatFlags ExternalLeading;
	public TextFormatFlags Default;
	public TextFormatFlags HidePrefix;
	public TextFormatFlags HorizontalCenter;
	public TextFormatFlags Internal;
	public TextFormatFlags Left;
	public TextFormatFlags ModifyString;
	public TextFormatFlags NoClipping;
	public TextFormatFlags NoPrefix;
	public TextFormatFlags NoFullWidthCharacterBreak;
	public TextFormatFlags PathEllipsis;
	public TextFormatFlags PrefixOnly;
	public TextFormatFlags Right;
	public TextFormatFlags RightToLeft;
	public TextFormatFlags SingleLine;
	public TextFormatFlags TextBoxControl;
	public TextFormatFlags Top;
	public TextFormatFlags VerticalCenter;
	public TextFormatFlags WordBreak;
	public TextFormatFlags WordEllipsis;
	public TextFormatFlags PreserveGraphicsClipping;
	public TextFormatFlags PreserveGraphicsTranslateTransform;
	public TextFormatFlags GlyphOverhangPadding;
	public TextFormatFlags NoPadding;
	public TextFormatFlags LeftAndRightPadding;
}

