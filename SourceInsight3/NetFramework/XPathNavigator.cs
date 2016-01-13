public class XPathNavigator : XPathItem, System.ICloneable, IXPathNavigable, System.Xml.IXmlNamespaceResolver
{

	// Methods
	public virtual string ToString() {}
	public virtual void SetValue(string value) {}
	public virtual void SetTypedValue(object typedValue) {}
	public virtual object ValueAs(Type returnType, System.Xml.IXmlNamespaceResolver nsResolver) {}
	public virtual XPathNavigator CreateNavigator() {}
	public virtual string LookupNamespace(string prefix) {}
	public virtual string LookupPrefix(string namespaceURI) {}
	public virtual IDictionary<string,string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) {}
	public abstract virtual XPathNavigator Clone() {}
	public virtual System.Xml.XmlReader ReadSubtree() {}
	public virtual void WriteSubtree(System.Xml.XmlWriter writer) {}
	public virtual string GetAttribute(string localName, string namespaceURI) {}
	public virtual bool MoveToAttribute(string localName, string namespaceURI) {}
	public abstract virtual bool MoveToFirstAttribute() {}
	public abstract virtual bool MoveToNextAttribute() {}
	public virtual string GetNamespace(string name) {}
	public virtual bool MoveToNamespace(string name) {}
	public abstract virtual bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) {}
	public abstract virtual bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) {}
	public bool MoveToFirstNamespace() {}
	public bool MoveToNextNamespace() {}
	public abstract virtual bool MoveToNext() {}
	public abstract virtual bool MoveToPrevious() {}
	public virtual bool MoveToFirst() {}
	public abstract virtual bool MoveToFirstChild() {}
	public abstract virtual bool MoveToParent() {}
	public virtual void MoveToRoot() {}
	public abstract virtual bool MoveTo(XPathNavigator other) {}
	public abstract virtual bool MoveToId(string id) {}
	public virtual bool MoveToChild(string localName, string namespaceURI) {}
	public virtual bool MoveToChild(XPathNodeType type) {}
	public virtual bool MoveToFollowing(string localName, string namespaceURI) {}
	public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) {}
	public virtual bool MoveToFollowing(XPathNodeType type) {}
	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) {}
	public virtual bool MoveToNext(string localName, string namespaceURI) {}
	public virtual bool MoveToNext(XPathNodeType type) {}
	public abstract virtual bool IsSamePosition(XPathNavigator other) {}
	public virtual bool IsDescendant(XPathNavigator nav) {}
	public virtual System.Xml.XmlNodeOrder ComparePosition(XPathNavigator nav) {}
	public virtual bool CheckValidity(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.ValidationEventHandler validationEventHandler) {}
	public virtual XPathExpression Compile(string xpath) {}
	public virtual XPathNavigator SelectSingleNode(string xpath) {}
	public virtual XPathNavigator SelectSingleNode(string xpath, System.Xml.IXmlNamespaceResolver resolver) {}
	public virtual XPathNavigator SelectSingleNode(XPathExpression expression) {}
	public virtual XPathNodeIterator Select(string xpath) {}
	public virtual XPathNodeIterator Select(string xpath, System.Xml.IXmlNamespaceResolver resolver) {}
	public virtual XPathNodeIterator Select(XPathExpression expr) {}
	public virtual object Evaluate(string xpath) {}
	public virtual object Evaluate(string xpath, System.Xml.IXmlNamespaceResolver resolver) {}
	public virtual object Evaluate(XPathExpression expr) {}
	public virtual object Evaluate(XPathExpression expr, XPathNodeIterator context) {}
	public virtual bool Matches(XPathExpression expr) {}
	public virtual bool Matches(string xpath) {}
	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) {}
	public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI) {}
	public virtual XPathNodeIterator SelectAncestors(XPathNodeType type, bool matchSelf) {}
	public virtual XPathNodeIterator SelectAncestors(string name, string namespaceURI, bool matchSelf) {}
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) {}
	public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) {}
	public virtual System.Xml.XmlWriter PrependChild() {}
	public virtual System.Xml.XmlWriter AppendChild() {}
	public virtual System.Xml.XmlWriter InsertAfter() {}
	public virtual System.Xml.XmlWriter InsertBefore() {}
	public virtual System.Xml.XmlWriter CreateAttributes() {}
	public virtual System.Xml.XmlWriter ReplaceRange(XPathNavigator lastSiblingToReplace) {}
	public virtual void ReplaceSelf(string newNode) {}
	public virtual void ReplaceSelf(System.Xml.XmlReader newNode) {}
	public virtual void ReplaceSelf(XPathNavigator newNode) {}
	public virtual void AppendChild(string newChild) {}
	public virtual void AppendChild(System.Xml.XmlReader newChild) {}
	public virtual void AppendChild(XPathNavigator newChild) {}
	public virtual void PrependChild(string newChild) {}
	public virtual void PrependChild(System.Xml.XmlReader newChild) {}
	public virtual void PrependChild(XPathNavigator newChild) {}
	public virtual void InsertBefore(string newSibling) {}
	public virtual void InsertBefore(System.Xml.XmlReader newSibling) {}
	public virtual void InsertBefore(XPathNavigator newSibling) {}
	public virtual void InsertAfter(string newSibling) {}
	public virtual void InsertAfter(System.Xml.XmlReader newSibling) {}
	public virtual void InsertAfter(XPathNavigator newSibling) {}
	public virtual void DeleteRange(XPathNavigator lastSiblingToDelete) {}
	public virtual void DeleteSelf() {}
	public virtual void PrependChildElement(string prefix, string localName, string namespaceURI, string value) {}
	public virtual void AppendChildElement(string prefix, string localName, string namespaceURI, string value) {}
	public virtual void InsertElementBefore(string prefix, string localName, string namespaceURI, string value) {}
	public virtual void InsertElementAfter(string prefix, string localName, string namespaceURI, string value) {}
	public virtual void CreateAttribute(string prefix, string localName, string namespaceURI, string value) {}
	public virtual object ValueAs(Type returnType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsNode { get{} }
	public System.Xml.Schema.XmlSchemaType XmlType { get{} }
	public object TypedValue { get{} }
	public Type ValueType { get{} }
	public bool ValueAsBoolean { get{} }
	public System.DateTime ValueAsDateTime { get{} }
	public double ValueAsDouble { get{} }
	public int ValueAsInt { get{} }
	public long ValueAsLong { get{} }
	public System.Xml.XmlNameTable NameTable { get{} }
	public System.Collections.IEqualityComparer NavigatorComparer { get{} }
	public XPathNodeType NodeType { get{} }
	public string LocalName { get{} }
	public string Name { get{} }
	public string NamespaceURI { get{} }
	public string Prefix { get{} }
	public string BaseURI { get{} }
	public bool IsEmptyElement { get{} }
	public string XmlLang { get{} }
	public object UnderlyingObject { get{} }
	public bool HasAttributes { get{} }
	public bool HasChildren { get{} }
	public System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get{} }
	public bool CanEdit { get{} }
	public string OuterXml { get{} set{} }
	public string InnerXml { get{} set{} }
	public string Value { get{} }
}

