public class XmlSchemaExporter
{

	// Constructors
	public XmlSchemaExporter(XmlSchemas schemas) {}

	// Methods
	public void ExportTypeMapping(XmlTypeMapping xmlTypeMapping) {}
	public System.Xml.XmlQualifiedName ExportTypeMapping(XmlMembersMapping xmlMembersMapping) {}
	public void ExportMembersMapping(XmlMembersMapping xmlMembersMapping) {}
	public void ExportMembersMapping(XmlMembersMapping xmlMembersMapping, bool exportEnclosingType) {}
	public string ExportAnyType(string ns) {}
	public string ExportAnyType(XmlMembersMapping members) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

