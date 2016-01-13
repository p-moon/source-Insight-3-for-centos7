public class MethodData
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public ManagementBaseObject InParameters { get{} }
	public ManagementBaseObject OutParameters { get{} }
	public string Origin { get{} }
	public QualifierDataCollection Qualifiers { get{} }
}

