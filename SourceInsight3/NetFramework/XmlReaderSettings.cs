public class XmlReaderSettings
{

	// Constructors
	public XmlReaderSettings() {}

	// Methods
	public void Reset() {}
	public XmlReaderSettings Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlNameTable NameTable { get{} set{} }
	public XmlResolver XmlResolver { set{} }
	public int LineNumberOffset { get{} set{} }
	public int LinePositionOffset { get{} set{} }
	public ConformanceLevel ConformanceLevel { get{} set{} }
	public bool CheckCharacters { get{} set{} }
	public long MaxCharactersInDocument { get{} set{} }
	public long MaxCharactersFromEntities { get{} set{} }
	public ValidationType ValidationType { get{} set{} }
	public System.Xml.Schema.XmlSchemaValidationFlags ValidationFlags { get{} set{} }
	public System.Xml.Schema.XmlSchemaSet Schemas { get{} set{} }
	public bool IgnoreWhitespace { get{} set{} }
	public bool IgnoreProcessingInstructions { get{} set{} }
	public bool IgnoreComments { get{} set{} }
	public bool ProhibitDtd { get{} set{} }
	public bool CloseInput { get{} set{} }

	// Events
	public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler;
}

