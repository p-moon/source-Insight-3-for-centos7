public class XmlCodeExporter : CodeExporter
{

	// Constructors
	public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace) {}
	public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit) {}
	public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit, CodeGenerationOptions options) {}
	public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit, CodeGenerationOptions options, System.Collections.Hashtable mappings) {}
	public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit, System.CodeDom.Compiler.CodeDomProvider codeProvider, CodeGenerationOptions options, System.Collections.Hashtable mappings) {}

	// Methods
	public void ExportTypeMapping(XmlTypeMapping xmlTypeMapping) {}
	public void ExportMembersMapping(XmlMembersMapping xmlMembersMapping) {}
	public void AddMappingMetadata(System.CodeDom.CodeAttributeDeclarationCollection metadata, XmlTypeMapping mapping, string ns) {}
	public void AddMappingMetadata(System.CodeDom.CodeAttributeDeclarationCollection metadata, XmlMemberMapping member, string ns, bool forceUseMemberName) {}
	public void AddMappingMetadata(System.CodeDom.CodeAttributeDeclarationCollection metadata, XmlMemberMapping member, string ns) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.CodeDom.CodeAttributeDeclarationCollection IncludeMetadata { get{} }
}

