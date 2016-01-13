public class XmlReflectionImporter
{

	// Constructors
	public XmlReflectionImporter() {}
	public XmlReflectionImporter(string defaultNamespace) {}
	public XmlReflectionImporter(XmlAttributeOverrides attributeOverrides) {}
	public XmlReflectionImporter(XmlAttributeOverrides attributeOverrides, string defaultNamespace) {}

	// Methods
	public void IncludeTypes(System.Reflection.ICustomAttributeProvider provider) {}
	public void IncludeType(Type type) {}
	public XmlTypeMapping ImportTypeMapping(Type type) {}
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) {}
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root) {}
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) {}
	public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement) {}
	public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement, bool rpc) {}
	public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement, bool rpc, bool openModel) {}
	public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement, bool rpc, bool openModel, XmlMappingAccess access) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

