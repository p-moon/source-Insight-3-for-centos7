public class XmlWriter : System.IDisposable
{

	// Methods
	public void WriteStartElement(string localName) {}
	public void WriteAttributeString(string localName, string value) {}
	public abstract virtual void WriteStartDocument() {}
	public abstract virtual void WriteStartDocument(bool standalone) {}
	public abstract virtual void WriteEndDocument() {}
	public abstract virtual void WriteDocType(string name, string pubid, string sysid, string subset) {}
	public void WriteStartElement(string localName, string ns) {}
	public abstract virtual void WriteStartElement(string prefix, string localName, string ns) {}
	public abstract virtual void WriteEndElement() {}
	public abstract virtual void WriteFullEndElement() {}
	public void WriteAttributeString(string localName, string ns, string value) {}
	public void WriteAttributeString(string prefix, string localName, string ns, string value) {}
	public void WriteStartAttribute(string localName, string ns) {}
	public abstract virtual void WriteStartAttribute(string prefix, string localName, string ns) {}
	public void WriteStartAttribute(string localName) {}
	public abstract virtual void WriteEndAttribute() {}
	public abstract virtual void WriteCData(string text) {}
	public abstract virtual void WriteComment(string text) {}
	public abstract virtual void WriteProcessingInstruction(string name, string text) {}
	public abstract virtual void WriteEntityRef(string name) {}
	public abstract virtual void WriteCharEntity(char ch) {}
	public abstract virtual void WriteWhitespace(string ws) {}
	public abstract virtual void WriteString(string text) {}
	public abstract virtual void WriteSurrogateCharEntity(char lowChar, char highChar) {}
	public abstract virtual void WriteChars(char[] buffer, int index, int count) {}
	public abstract virtual void WriteRaw(char[] buffer, int index, int count) {}
	public abstract virtual void WriteRaw(string data) {}
	public abstract virtual void WriteBase64(byte[] buffer, int index, int count) {}
	public virtual void WriteBinHex(byte[] buffer, int index, int count) {}
	public abstract virtual void Close() {}
	public abstract virtual void Flush() {}
	public abstract virtual string LookupPrefix(string ns) {}
	public virtual void WriteNmToken(string name) {}
	public virtual void WriteName(string name) {}
	public virtual void WriteQualifiedName(string localName, string ns) {}
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
	public static XmlWriter Create(string outputFileName) {}
	public static XmlWriter Create(string outputFileName, XmlWriterSettings settings) {}
	public static XmlWriter Create(System.IO.Stream output) {}
	public static XmlWriter Create(System.IO.Stream output, XmlWriterSettings settings) {}
	public static XmlWriter Create(System.IO.TextWriter output) {}
	public static XmlWriter Create(System.IO.TextWriter output, XmlWriterSettings settings) {}
	public static XmlWriter Create(System.Text.StringBuilder output) {}
	public static XmlWriter Create(System.Text.StringBuilder output, XmlWriterSettings settings) {}
	public static XmlWriter Create(XmlWriter output) {}
	public static XmlWriter Create(XmlWriter output, XmlWriterSettings settings) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlWriterSettings Settings { get{} }
	public WriteState WriteState { get{} }
	public XmlSpace XmlSpace { get{} }
	public string XmlLang { get{} }
}

