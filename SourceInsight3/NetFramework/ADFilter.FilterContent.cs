public class FilterContent : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.Collections.ArrayList And;
	public System.Collections.ArrayList Or;
	public ADFilter Not;
	public ADAttribute EqualityMatch;
	public ADSubstringFilter Substrings;
	public ADAttribute GreaterOrEqual;
	public ADAttribute LessOrEqual;
	public string Present;
	public ADAttribute ApproxMatch;
	public ADExtenMatchFilter ExtensibleMatch;
}

