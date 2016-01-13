public class XmlSerializerAssemblyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlSerializerAssemblyAttribute() {}
	public XmlSerializerAssemblyAttribute(string assemblyName) {}
	public XmlSerializerAssemblyAttribute(string assemblyName, string codeBase) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string CodeBase { get{} set{} }
	public string AssemblyName { get{} set{} }
	public object TypeId { get{} }
}

