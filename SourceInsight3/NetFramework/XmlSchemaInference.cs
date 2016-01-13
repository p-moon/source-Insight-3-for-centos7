public class XmlSchemaInference
{

	// Constructors
	public XmlSchemaInference() {}

	// Methods
	public XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument) {}
	public XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument, XmlSchemaSet schemas) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public InferenceOption Occurrence { get{} set{} }
	public InferenceOption TypeInference { get{} set{} }
}

