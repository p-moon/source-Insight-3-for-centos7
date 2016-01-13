public class VlvResponseControl : DirectoryControl
{

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int TargetPosition { get{} }
	public int ContentCount { get{} }
	public byte[] ContextId { get{} }
	public ResultCode Result { get{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

