public class ApplicationInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ID { get{} }
	public string VirtualPath { get{} }
	public string PhysicalPath { get{} }
}

