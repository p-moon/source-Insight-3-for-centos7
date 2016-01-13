public class TagPrefixAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public TagPrefixAttribute(string namespaceName, string tagPrefix) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string NamespaceName { get{} }
	public string TagPrefix { get{} }
	public object TypeId { get{} }
}

