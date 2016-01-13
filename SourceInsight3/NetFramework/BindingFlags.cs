public class BindingFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public BindingFlags Default;
	public BindingFlags IgnoreCase;
	public BindingFlags DeclaredOnly;
	public BindingFlags Instance;
	public BindingFlags Static;
	public BindingFlags Public;
	public BindingFlags NonPublic;
	public BindingFlags FlattenHierarchy;
	public BindingFlags InvokeMethod;
	public BindingFlags CreateInstance;
	public BindingFlags GetField;
	public BindingFlags SetField;
	public BindingFlags GetProperty;
	public BindingFlags SetProperty;
	public BindingFlags PutDispProperty;
	public BindingFlags PutRefDispProperty;
	public BindingFlags ExactBinding;
	public BindingFlags SuppressChangeType;
	public BindingFlags OptionalParamBinding;
	public BindingFlags IgnoreReturn;
}

