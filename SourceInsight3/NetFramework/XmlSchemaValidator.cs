public class XmlSchemaValidator
{

	// Constructors
	public XmlSchemaValidator(System.Xml.XmlNameTable nameTable, XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) {}

	// Methods
	public void AddSchema(XmlSchema schema) {}
	public void Initialize() {}
	public void Initialize(XmlSchemaObject partialValidationType) {}
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo) {}
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) {}
	public object ValidateAttribute(string localName, string namespaceUri, string attributeValue, XmlSchemaInfo schemaInfo) {}
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) {}
	public void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes) {}
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) {}
	public void ValidateText(string elementValue) {}
	public void ValidateText(XmlValueGetter elementValue) {}
	public void ValidateWhitespace(string elementValue) {}
	public void ValidateWhitespace(XmlValueGetter elementValue) {}
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) {}
	public object ValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) {}
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) {}
	public void EndValidation() {}
	public XmlSchemaParticle[] GetExpectedParticles() {}
	public XmlSchemaAttribute[] GetExpectedAttributes() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlResolver XmlResolver { set{} }
	public System.Xml.IXmlLineInfo LineInfoProvider { get{} set{} }
	public System.Uri SourceUri { get{} set{} }
	public object ValidationEventSender { get{} set{} }

	// Events
	public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler;
}

