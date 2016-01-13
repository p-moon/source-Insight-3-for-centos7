public class Switch
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.StringDictionary Attributes { get{} }
	public string DisplayName { get{} }
	public string Description { get{} }
}

