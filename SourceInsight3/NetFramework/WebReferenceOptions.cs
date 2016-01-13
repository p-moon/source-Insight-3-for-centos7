public class WebReferenceOptions
{

	// Constructors
	public WebReferenceOptions() {}

	// Methods
	public static WebReferenceOptions Read(System.IO.TextReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler) {}
	public static WebReferenceOptions Read(System.IO.Stream stream, System.Xml.Schema.ValidationEventHandler validationEventHandler) {}
	public static WebReferenceOptions Read(System.Xml.XmlReader xmlReader, System.Xml.Schema.ValidationEventHandler validationEventHandler) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string TargetNamespace;

	// Properties
	public System.Xml.Serialization.CodeGenerationOptions CodeGenerationOptions { get{} set{} }
	public System.Collections.Specialized.StringCollection SchemaImporterExtensions { get{} }
	public ServiceDescriptionImportStyle Style { get{} set{} }
	public bool Verbose { get{} set{} }
	public System.Xml.Schema.XmlSchema Schema { get{} }
}

