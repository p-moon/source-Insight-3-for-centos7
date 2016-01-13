public class ManagementPath : System.ICloneable
{

	// Constructors
	public ManagementPath() {}
	public ManagementPath(string path) {}

	// Methods
	public virtual string ToString() {}
	public ManagementPath Clone() {}
	public void SetAsClass() {}
	public void SetAsSingleton() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ManagementPath DefaultPath { get{} set{} }
	public string Path { get{} set{} }
	public string RelativePath { get{} set{} }
	public string Server { get{} set{} }
	public string NamespacePath { get{} set{} }
	public string ClassName { get{} set{} }
	public bool IsClass { get{} }
	public bool IsInstance { get{} }
	public bool IsSingleton { get{} }
}

