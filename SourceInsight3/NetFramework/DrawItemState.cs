public class DrawItemState : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public DrawItemState Checked;
	public DrawItemState ComboBoxEdit;
	public DrawItemState Default;
	public DrawItemState Disabled;
	public DrawItemState Focus;
	public DrawItemState Grayed;
	public DrawItemState HotLight;
	public DrawItemState Inactive;
	public DrawItemState NoAccelerator;
	public DrawItemState NoFocusRect;
	public DrawItemState Selected;
	public DrawItemState None;
}

