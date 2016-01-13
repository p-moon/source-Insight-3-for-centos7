public class ProtocolImporter
{

	// Methods
	public void AddExtensionWarningComments(System.CodeDom.CodeCommentStatementCollection comments, ServiceDescriptionFormatExtensionCollection extensions) {}
	public void UnsupportedBindingWarning(string text) {}
	public void UnsupportedOperationWarning(string text) {}
	public void UnsupportedOperationBindingWarning(string text) {}
	public System.Exception OperationSyntaxException(string text) {}
	public System.Exception OperationBindingSyntaxException(string text) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ServiceDescriptionCollection ServiceDescriptions { get{} }
	public System.Xml.Serialization.XmlSchemas Schemas { get{} }
	public System.Xml.Serialization.XmlSchemas AbstractSchemas { get{} }
	public System.Xml.Serialization.XmlSchemas ConcreteSchemas { get{} }
	public System.CodeDom.CodeNamespace CodeNamespace { get{} }
	public System.CodeDom.CodeTypeDeclaration CodeTypeDeclaration { get{} }
	public ServiceDescriptionImportStyle Style { get{} }
	public ServiceDescriptionImportWarnings Warnings { get{} set{} }
	public System.Xml.Serialization.CodeIdentifiers ClassNames { get{} }
	public string MethodName { get{} }
	public string ClassName { get{} }
	public Port Port { get{} }
	public PortType PortType { get{} }
	public Binding Binding { get{} }
	public Service Service { get{} }
	public Operation Operation { get{} }
	public OperationBinding OperationBinding { get{} }
	public Message InputMessage { get{} }
	public Message OutputMessage { get{} }
	public string ProtocolName { get{} }
}

