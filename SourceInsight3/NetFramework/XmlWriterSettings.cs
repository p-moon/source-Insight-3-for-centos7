public class XmlWriterSettings
{

	// Constructors
	public XmlWriterSettings() {}

	// Methods
	public void Reset() {}
	public XmlWriterSettings Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Text.Encoding Encoding { get{} set{} }
	public bool OmitXmlDeclaration { get{} set{} }
	public NewLineHandling NewLineHandling { get{} set{} }
	public string NewLineChars { get{} set{} }
	public bool Indent { get{} set{} }
	public string IndentChars { get{} set{} }
	public bool NewLineOnAttributes { get{} set{} }
	public bool CloseOutput { get{} set{} }
	public ConformanceLevel ConformanceLevel { get{} set{} }
	public bool CheckCharacters { get{} set{} }
	public XmlOutputMethod OutputMethod { get{} set{} }
}

