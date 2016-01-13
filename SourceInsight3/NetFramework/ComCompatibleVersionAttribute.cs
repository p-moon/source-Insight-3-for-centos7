public class ComCompatibleVersionAttribute : System.Attribute, _Attribute
{

	// Constructors
	public ComCompatibleVersionAttribute(int major, int minor, int build, int revision) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int MajorVersion { get{} }
	public int MinorVersion { get{} }
	public int BuildNumber { get{} }
	public int RevisionNumber { get{} }
	public object TypeId { get{} }
}

