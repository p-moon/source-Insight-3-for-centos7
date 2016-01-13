public class SystemParameter : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public SystemParameter DropShadow;
	public SystemParameter FlatMenu;
	public SystemParameter FontSmoothingContrastMetric;
	public SystemParameter FontSmoothingTypeMetric;
	public SystemParameter MenuFadeEnabled;
	public SystemParameter SelectionFade;
	public SystemParameter ToolTipAnimationMetric;
	public SystemParameter UIEffects;
	public SystemParameter CaretWidthMetric;
	public SystemParameter VerticalFocusThicknessMetric;
	public SystemParameter HorizontalFocusThicknessMetric;
}

