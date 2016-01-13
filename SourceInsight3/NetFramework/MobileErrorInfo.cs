public class MobileErrorInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string ContextKey;

	// Properties
	public string Item { get{} set{} }
	public string Type { get{} set{} }
	public string Description { get{} set{} }
	public string MiscTitle { get{} set{} }
	public string MiscText { get{} set{} }
	public string File { get{} set{} }
	public string LineNumber { get{} set{} }
}

