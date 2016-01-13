public class XmlQueryOutput : System.Xml.XmlWriter, System.IDisposable
{

	// Methods
	public virtual void WriteStartDocument() {}
	public virtual void WriteStartDocument(bool standalone) {}
	public virtual void WriteEndDocument() {}
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) {}
	public virtual void WriteStartElement(string prefix, string localName, string ns) {}
	public virtual void WriteEndElement() {}
	public virtual void WriteFullEndElement() {}
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) {}
	public virtual void WriteEndAttribute() {}
	public virtual void WriteComment(string text) {}
	public virtual void WriteProcessingInstruction(string target, string text) {}
	public virtual void WriteEntityRef(string name) {}
	public virtual void WriteCharEntity(char ch) {}
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) {}
	public virtual void WriteWhitespace(string ws) {}
	public virtual void WriteString(string text) {}
	public virtual void WriteChars(char[] buffer, int index, int count) {}
	public virtual void WriteRaw(char[] buffer, int index, int count) {}
	public virtual void WriteRaw(string data) {}
	public virtual void WriteCData(string text) {}
	public virtual void WriteBase64(byte[] buffer, int index, int count) {}
	public virtual void Close() {}
	public virtual void Flush() {}
	public virtual string LookupPrefix(string ns) {}
	public void StartTree(System.Xml.XPath.XPathNodeType rootType) {}
	public void EndTree() {}
	public void WriteStartElementUnchecked(string prefix, string localName, string ns) {}
	public void WriteStartElementUnchecked(string localName) {}
	public void StartElementContentUnchecked() {}
	public void WriteEndElementUnchecked(string prefix, string localName, string ns) {}
	public void WriteEndElementUnchecked(string localName) {}
	public void WriteStartAttributeUnchecked(string prefix, string localName, string ns) {}
	public void WriteStartAttributeUnchecked(string localName) {}
	public void WriteEndAttributeUnchecked() {}
	public void WriteNamespaceDeclarationUnchecked(string prefix, string ns) {}
	public void WriteStringUnchecked(string text) {}
	public void WriteRawUnchecked(string text) {}
	public void WriteStartRoot() {}
	public void WriteEndRoot() {}
	public void WriteStartElementLocalName(string localName) {}
	public void WriteStartAttributeLocalName(string localName) {}
	public void WriteStartElementComputed(string tagName, int prefixMappingsIndex) {}
	public void WriteStartElementComputed(string tagName, string ns) {}
	public void WriteStartElementComputed(System.Xml.XPath.XPathNavigator navigator) {}
	public void WriteStartElementComputed(System.Xml.XmlQualifiedName name) {}
	public void WriteStartAttributeComputed(string tagName, int prefixMappingsIndex) {}
	public void WriteStartAttributeComputed(string tagName, string ns) {}
	public void WriteStartAttributeComputed(System.Xml.XPath.XPathNavigator navigator) {}
	public void WriteStartAttributeComputed(System.Xml.XmlQualifiedName name) {}
	public void WriteNamespaceDeclaration(string prefix, string ns) {}
	public void WriteStartNamespace(string prefix) {}
	public void WriteNamespaceString(string text) {}
	public void WriteEndNamespace() {}
	public void WriteStartComment() {}
	public void WriteCommentString(string text) {}
	public void WriteEndComment() {}
	public void WriteStartProcessingInstruction(string target) {}
	public void WriteProcessingInstructionString(string text) {}
	public void WriteEndProcessingInstruction() {}
	public void WriteItem(System.Xml.XPath.XPathItem item) {}
	public void XsltCopyOf(System.Xml.XPath.XPathNavigator navigator) {}
	public bool StartCopy(System.Xml.XPath.XPathNavigator navigator) {}
	public void EndCopy(System.Xml.XPath.XPathNavigator navigator) {}
	public void WriteStartElement(string localName) {}
	public void WriteAttributeString(string localName, string value) {}
	public void WriteStartElement(string localName, string ns) {}
	public void WriteAttributeString(string localName, string ns, string value) {}
	public void WriteAttributeString(string prefix, string localName, string ns, string value) {}
	public void WriteStartAttribute(string localName, string ns) {}
	public void WriteStartAttribute(string localName) {}
	public virtual void WriteBinHex(byte[] buffer, int index, int count) {}
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
	public virtual void WriteAttributes(System.Xml.XmlReader reader, bool defattr) {}
	public virtual void WriteNode(System.Xml.XmlReader reader, bool defattr) {}
	public virtual void WriteNode(System.Xml.XPath.XPathNavigator navigator, bool defattr) {}
	public void WriteElementString(string localName, string value) {}
	public void WriteElementString(string localName, string ns, string value) {}
	public void WriteElementString(string prefix, string localName, string ns, string value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.WriteState WriteState { get{} }
	public System.Xml.XmlSpace XmlSpace { get{} }
	public string XmlLang { get{} }
	public System.Xml.XmlWriterSettings Settings { get{} }
}

