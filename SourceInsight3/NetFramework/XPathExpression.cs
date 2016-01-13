public class XPathExpression
{

	// Methods
	public abstract virtual void AddSort(object expr, System.Collections.IComparer comparer) {}
	public abstract virtual void AddSort(object expr, XmlSortOrder order, XmlCaseOrder caseOrder, string lang, XmlDataType dataType) {}
	public abstract virtual XPathExpression Clone() {}
	public abstract virtual void SetContext(System.Xml.XmlNamespaceManager nsManager) {}
	public abstract virtual void SetContext(System.Xml.IXmlNamespaceResolver nsResolver) {}
	public static XPathExpression Compile(string xpath) {}
	public static XPathExpression Compile(string xpath, System.Xml.IXmlNamespaceResolver nsResolver) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Expression { get{} }
	public XPathResultType ReturnType { get{} }
}

