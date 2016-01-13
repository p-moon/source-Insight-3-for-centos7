public class AccessibleStates : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public AccessibleStates None;
	public AccessibleStates Unavailable;
	public AccessibleStates Selected;
	public AccessibleStates Focused;
	public AccessibleStates Pressed;
	public AccessibleStates Checked;
	public AccessibleStates Mixed;
	public AccessibleStates Indeterminate;
	public AccessibleStates ReadOnly;
	public AccessibleStates HotTracked;
	public AccessibleStates Default;
	public AccessibleStates Expanded;
	public AccessibleStates Collapsed;
	public AccessibleStates Busy;
	public AccessibleStates Floating;
	public AccessibleStates Marqueed;
	public AccessibleStates Animated;
	public AccessibleStates Invisible;
	public AccessibleStates Offscreen;
	public AccessibleStates Sizeable;
	public AccessibleStates Moveable;
	public AccessibleStates SelfVoicing;
	public AccessibleStates Focusable;
	public AccessibleStates Selectable;
	public AccessibleStates Linked;
	public AccessibleStates Traversed;
	public AccessibleStates MultiSelectable;
	public AccessibleStates ExtSelectable;
	public AccessibleStates AlertLow;
	public AccessibleStates AlertMedium;
	public AccessibleStates AlertHigh;
	public AccessibleStates Protected;
	public AccessibleStates HasPopup;
	public AccessibleStates Valid;
}

