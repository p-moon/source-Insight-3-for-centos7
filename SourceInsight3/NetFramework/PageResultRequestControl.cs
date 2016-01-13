public class PageResultRequestControl : DirectoryControl
{

	// Constructors
	public PageResultRequestControl() {}
	public PageResultRequestControl(int pageSize) {}
	public PageResultRequestControl(byte[] cookie) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int PageSize { get{} set{} }
	public byte[] Cookie { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

