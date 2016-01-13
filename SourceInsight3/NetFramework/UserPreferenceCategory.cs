public class UserPreferenceCategory : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public UserPreferenceCategory Accessibility;
	public UserPreferenceCategory Color;
	public UserPreferenceCategory Desktop;
	public UserPreferenceCategory General;
	public UserPreferenceCategory Icon;
	public UserPreferenceCategory Keyboard;
	public UserPreferenceCategory Menu;
	public UserPreferenceCategory Mouse;
	public UserPreferenceCategory Policy;
	public UserPreferenceCategory Power;
	public UserPreferenceCategory Screensaver;
	public UserPreferenceCategory Window;
	public UserPreferenceCategory Locale;
	public UserPreferenceCategory VisualStyle;
}

