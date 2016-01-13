public class ServiceDescriptionImporter
{

	// Constructors
	public ServiceDescriptionImporter() {}

	// Methods
	public void AddServiceDescription(ServiceDescription serviceDescription, string appSettingUrlKey, string appSettingBaseUrl) {}
	public ServiceDescriptionImportWarnings Import(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit) {}
	public static System.Collections.Specialized.StringCollection GenerateWebReferences(WebReferenceCollection webReferences, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.CodeDom.CodeCompileUnit codeCompileUnit, WebReferenceOptions options) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ServiceDescriptionCollection ServiceDescriptions { get{} }
	public System.Xml.Serialization.XmlSchemas Schemas { get{} }
	public ServiceDescriptionImportStyle Style { get{} set{} }
	public System.Xml.Serialization.CodeGenerationOptions CodeGenerationOptions { get{} set{} }
	public System.CodeDom.Compiler.CodeDomProvider CodeGenerator { get{} set{} }
	public string ProtocolName { get{} set{} }
}

