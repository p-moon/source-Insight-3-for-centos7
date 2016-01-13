public class SortRequestControl : DirectoryControl
{

	// Constructors
	public SortRequestControl(SortKey[] sortKeys) {}
	public SortRequestControl(string attributeName, bool reverseOrder) {}
	public SortRequestControl(string attributeName, string matchingRule, bool reverseOrder) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SortKey[] SortKeys { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

