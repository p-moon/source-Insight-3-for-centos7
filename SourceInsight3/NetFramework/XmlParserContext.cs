public class XmlParserContext
{

	// Constructors
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) {}
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace, System.Text.Encoding enc) {}
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) {}
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, System.Text.Encoding enc) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlNameTable NameTable { get{} set{} }
	public XmlNamespaceManager NamespaceManager { get{} set{} }
	public string DocTypeName { get{} set{} }
	public string PublicId { get{} set{} }
	public string SystemId { get{} set{} }
	public string BaseURI { get{} set{} }
	public string InternalSubset { get{} set{} }
	public string XmlLang { get{} set{} }
	public XmlSpace XmlSpace { get{} set{} }
	public System.Text.Encoding Encoding { get{} set{} }
}

