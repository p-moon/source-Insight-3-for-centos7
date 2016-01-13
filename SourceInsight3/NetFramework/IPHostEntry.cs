public class IPHostEntry
{

	// Constructors
	public IPHostEntry() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string HostName { get{} set{} }
	public string[] Aliases { get{} set{} }
	public IPAddress[] AddressList { get{} set{} }
}

