public class ContextInformation
{

	// Methods
	public object GetSection(string sectionName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object HostingContext { get{} }
	public bool IsMachineLevel { get{} }
}

