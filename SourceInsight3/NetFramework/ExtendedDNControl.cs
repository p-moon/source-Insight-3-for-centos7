public class ExtendedDNControl : DirectoryControl
{

	// Constructors
	public ExtendedDNControl() {}
	public ExtendedDNControl(ExtendedDNFlag flag) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ExtendedDNFlag Flag { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

