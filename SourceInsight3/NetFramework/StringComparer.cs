public class StringComparer : System.Collections.IComparer, System.Collections.IEqualityComparer, IComparer<string>, IEqualityComparer<string>
{

	// Methods
	public static StringComparer Create(System.Globalization.CultureInfo culture, bool ignoreCase) {}
	public virtual int Compare(object x, object y) {}
	public virtual bool Equals(object x, object y) {}
	public virtual int GetHashCode(object obj) {}
	public abstract virtual int Compare(string x, string y) {}
	public abstract virtual bool Equals(string x, string y) {}
	public abstract virtual int GetHashCode(string obj) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public StringComparer InvariantCulture { get{} }
	public StringComparer InvariantCultureIgnoreCase { get{} }
	public StringComparer CurrentCulture { get{} }
	public StringComparer CurrentCultureIgnoreCase { get{} }
	public StringComparer Ordinal { get{} }
	public StringComparer OrdinalIgnoreCase { get{} }
}

