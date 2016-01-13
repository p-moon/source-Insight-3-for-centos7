public class MyGroupCollectionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public MyGroupCollectionAttribute(string typeToCollect, string createInstanceMethodName, string disposeInstanceMethodName, string defaultInstanceAlias) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string MyGroupName { get{} }
	public string CreateMethod { get{} }
	public string DisposeMethod { get{} }
	public string DefaultInstanceAlias { get{} }
	public object TypeId { get{} }
}

