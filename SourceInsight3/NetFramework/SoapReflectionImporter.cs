public class SoapReflectionImporter
{

	// Constructors
	public SoapReflectionImporter() {}
	public SoapReflectionImporter(string defaultNamespace) {}
	public SoapReflectionImporter(SoapAttributeOverrides attributeOverrides) {}
	public SoapReflectionImporter(SoapAttributeOverrides attributeOverrides, string defaultNamespace) {}

	// Methods
	public void IncludeTypes(System.Reflection.ICustomAttributeProvider provider) {}
	public void IncludeType(Type type) {}
	public XmlTypeMapping ImportTypeMapping(Type type) {}
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) {}
	public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members) {}
	public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement, bool writeAccessors) {}
	public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement, bool writeAccessors, bool validate) {}
	public XmlMembersMapping ImportMembersMapping(string elementName, string ns, XmlReflectionMember[] members, bool hasWrapperElement, bool writeAccessors, bool validate, XmlMappingAccess access) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

