public class SortKey
{

	// Constructors
	public SortKey() {}
	public SortKey(string attributeName, string matchingRule, bool reverseOrder) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AttributeName { get{} set{} }
	public string MatchingRule { get{} set{} }
	public bool ReverseOrder { get{} set{} }
}

