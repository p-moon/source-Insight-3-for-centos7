public class PageResultResponseControl : DirectoryControl
{

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public byte[] Cookie { get{} }
	public int TotalCount { get{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

