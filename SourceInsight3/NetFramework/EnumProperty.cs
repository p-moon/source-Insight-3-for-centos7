public class EnumProperty : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public EnumProperty BackgroundType;
	public EnumProperty BorderType;
	public EnumProperty FillType;
	public EnumProperty SizingType;
	public EnumProperty HorizontalAlignment;
	public EnumProperty ContentAlignment;
	public EnumProperty VerticalAlignment;
	public EnumProperty OffsetType;
	public EnumProperty IconEffect;
	public EnumProperty TextShadowType;
	public EnumProperty ImageLayout;
	public EnumProperty GlyphType;
	public EnumProperty ImageSelectType;
	public EnumProperty GlyphFontSizingType;
	public EnumProperty TrueSizeScalingType;
}

