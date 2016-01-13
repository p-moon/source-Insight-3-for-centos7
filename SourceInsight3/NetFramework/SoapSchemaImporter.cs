public class SoapSchemaImporter : SchemaImporter
{

	// Constructors
	public SoapSchemaImporter(XmlSchemas schemas) {}
	public SoapSchemaImporter(XmlSchemas schemas, CodeIdentifiers typeIdentifiers) {}
	public SoapSchemaImporter(XmlSchemas schemas, CodeIdentifiers typeIdentifiers, CodeGenerationOptions options) {}
	public SoapSchemaImporter(XmlSchemas schemas, CodeGenerationOptions options, ImportContext context) {}
	public SoapSchemaImporter(XmlSchemas schemas, CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider, ImportContext context) {}

	// Methods
	public XmlTypeMapping ImportDerivedTypeMapping(System.Xml.XmlQualifiedName name, Type baseType, bool baseTypeCanBeIndirect) {}
	public XmlMembersMapping ImportMembersMapping(string name, string ns, SoapSchemaMember member) {}
	public XmlMembersMapping ImportMembersMapping(string name, string ns, SoapSchemaMember[] members) {}
	public XmlMembersMapping ImportMembersMapping(string name, string ns, SoapSchemaMember[] members, bool hasWrapperElement) {}
	public XmlMembersMapping ImportMembersMapping(string name, string ns, SoapSchemaMember[] members, bool hasWrapperElement, Type baseType, bool baseTypeCanBeIndirect) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection Extensions { get{} }
}

