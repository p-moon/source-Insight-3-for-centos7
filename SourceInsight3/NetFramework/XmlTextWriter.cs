public class XmlTextWriter : XmlWriter, System.IDisposable
{

	// Constructors
	public XmlTextWriter(string filename, System.Text.Encoding encoding) {}
	public XmlTextWriter(System.IO.Stream w, System.Text.Encoding encoding) {}
	public XmlTextWriter(System.IO.TextWriter w) {}

	// Methods
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) {}
	public virtual void WriteStartDocument() {}
	public virtual void WriteStartDocument(bool standalone) {}
	public virtual void WriteEndDocument() {}
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) {}
	public virtual void WriteStartElement(string prefix, string localName, string ns) {}
	public virtual void WriteEndElement() {}
	public virtual void WriteFullEndElement() {}
	public virtual void WriteEndAttribute() {}
	public virtual void WriteCData(string text) {}
	public virtual void WriteComment(string text) {}
	public virtual void WriteProcessingInstruction(string name, string text) {}
	public virtual void WriteEntityRef(string name) {}
	public virtual void WriteCharEntity(char ch) {}
	public virtual void WriteWhitespace(string ws) {}
	public virtual void WriteString(string text) {}
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) {}
	public virtual void WriteChars(char[] buffer, int index, int count) {}
	public virtual void WriteRaw(char[] buffer, int index, int count) {}
	public virtual void WriteRaw(string data) {}
	public virtual void WriteBase64(byte[] buffer, int index, int count) {}
	public virtual void WriteBinHex(byte[] buffer, int index, int count) {}
	public virtual void Close() {}
	public virtual void Flush() {}
	public virtual void WriteName(string name) {}
	public virtual void WriteQualifiedName(string localName, string ns) {}
	public virtual string LookupPrefix(string ns) {}
	public virtual void WriteNmToken(string name) {}
	public void WriteStartElement(string localName) {}
	public void WriteAttributeString(string localName, string value) {}
	public void WriteStartElement(string localName, string ns) {}
	public void WriteAttributeString(string localName, string ns, string value) {}
	public void WriteAttributeString(string prefix, string localName, string ns, string value) {}
	public void WriteStartAttribute(string localName, string ns) {}
	public void WriteStartAttribute(string localName) {}
	public virtual void WriteValue(object value) {}
	public virtual void WriteValue(string value) {}
	public virtual void WriteValue(bool value) {}
	public virtual void WriteValue(System.DateTime value) {}
	public virtual void WriteValue(double value) {}
	public virtual void WriteValue(float value) {}
	public virtual void WriteValue(decimal value) {}
	public virtual void WriteValue(int value) {}
	public virtual void WriteValue(long value) {}
	public virtual void WriteAttributes(XmlReader reader, bool defattr) {}
	public virtual void WriteNode(XmlReader reader, bool defattr) {}
	public virtual void WriteNode(System.Xml.XPath.XPathNavigator navigator, bool defattr) {}
	public void WriteElementString(string localName, string value) {}
	public void WriteElementString(string localName, string ns, string value) {}
	public void WriteElementString(string prefix, string localName, string ns, string value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IO.Stream BaseStream { get{} }
	public bool Namespaces { get{} set{} }
	public Formatting Formatting { get{} set{} }
	public int Indentation { get{} set{} }
	public char IndentChar { get{} set{} }
	public char QuoteChar { get{} set{} }
	public WriteState WriteState { get{} }
	public XmlSpace XmlSpace { get{} }
	public string XmlLang { get{} }
	public XmlWriterSettings Settings { get{} }
}

