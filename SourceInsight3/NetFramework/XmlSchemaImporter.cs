public class XmlSchemaImporter : SchemaImporter
{

	// Constructors
	public XmlSchemaImporter(XmlSchemas schemas) {}
	public XmlSchemaImporter(XmlSchemas schemas, CodeIdentifiers typeIdentifiers) {}
	public XmlSchemaImporter(XmlSchemas schemas, CodeIdentifiers typeIdentifiers, CodeGenerationOptions options) {}
	public XmlSchemaImporter(XmlSchemas schemas, CodeGenerationOptions options, ImportContext context) {}
	public XmlSchemaImporter(XmlSchemas schemas, CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider, ImportContext context) {}

	// Methods
	public XmlTypeMapping ImportDerivedTypeMapping(System.Xml.XmlQualifiedName name, Type baseType) {}
	public XmlTypeMapping ImportDerivedTypeMapping(System.Xml.XmlQualifiedName name, Type baseType, bool baseTypeCanBeIndirect) {}
	public XmlTypeMapping ImportSchemaType(System.Xml.XmlQualifiedName typeName) {}
	public XmlTypeMapping ImportSchemaType(System.Xml.XmlQualifiedName typeName, Type baseType) {}
	public XmlTypeMapping ImportSchemaType(System.Xml.XmlQualifiedName typeName, Type baseType, bool baseTypeCanBeIndirect) {}
	public XmlTypeMapping ImportTypeMapping(System.Xml.XmlQualifiedName name) {}
	public XmlMembersMapping ImportMembersMapping(System.Xml.XmlQualifiedName name) {}
	public XmlMembersMapping ImportAnyType(System.Xml.XmlQualifiedName typeName, string elementName) {}
	public XmlMembersMapping ImportMembersMapping(System.Xml.XmlQualifiedName[] names) {}
	public XmlMembersMapping ImportMembersMapping(System.Xml.XmlQualifiedName[] names, Type baseType, bool baseTypeCanBeIndirect) {}
	public XmlMembersMapping ImportMembersMapping(string name, string ns, SoapSchemaMember[] members) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection Extensions { get{} }
}

