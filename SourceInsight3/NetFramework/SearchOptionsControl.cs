public class SearchOptionsControl : DirectoryControl
{

	// Constructors
	public SearchOptionsControl() {}
	public SearchOptionsControl(SearchOption flags) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SearchOption SearchOption { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

