public class ControlStyles : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ControlStyles ContainerControl;
	public ControlStyles UserPaint;
	public ControlStyles Opaque;
	public ControlStyles ResizeRedraw;
	public ControlStyles FixedWidth;
	public ControlStyles FixedHeight;
	public ControlStyles StandardClick;
	public ControlStyles Selectable;
	public ControlStyles UserMouse;
	public ControlStyles SupportsTransparentBackColor;
	public ControlStyles StandardDoubleClick;
	public ControlStyles AllPaintingInWmPaint;
	public ControlStyles CacheText;
	public ControlStyles EnableNotifyMessage;
	public ControlStyles DoubleBuffer;
	public ControlStyles OptimizedDoubleBuffer;
	public ControlStyles UseTextForAccessibility;
}

