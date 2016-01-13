public class CaseInsensitiveComparer : IComparer
{

	// Constructors
	public CaseInsensitiveComparer() {}
	public CaseInsensitiveComparer(System.Globalization.CultureInfo culture) {}

	// Methods
	public virtual int Compare(object a, object b) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CaseInsensitiveComparer Default { get{} }
	public CaseInsensitiveComparer DefaultInvariant { get{} }
}

