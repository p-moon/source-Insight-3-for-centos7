public class XslTransform
{

	// Constructors
	public XslTransform() {}

	// Methods
	public void Load(System.Xml.XmlReader stylesheet) {}
	public void Load(System.Xml.XmlReader stylesheet, System.Xml.XmlResolver resolver) {}
	public void Load(System.Xml.XPath.IXPathNavigable stylesheet) {}
	public void Load(System.Xml.XPath.IXPathNavigable stylesheet, System.Xml.XmlResolver resolver) {}
	public void Load(System.Xml.XPath.XPathNavigator stylesheet) {}
	public void Load(System.Xml.XPath.XPathNavigator stylesheet, System.Xml.XmlResolver resolver) {}
	public void Load(string url) {}
	public void Load(string url, System.Xml.XmlResolver resolver) {}
	public void Load(System.Xml.XPath.IXPathNavigable stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) {}
	public void Load(System.Xml.XmlReader stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) {}
	public void Load(System.Xml.XPath.XPathNavigator stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) {}
	public System.Xml.XmlReader Transform(System.Xml.XPath.XPathNavigator input, XsltArgumentList args, System.Xml.XmlResolver resolver) {}
	public System.Xml.XmlReader Transform(System.Xml.XPath.XPathNavigator input, XsltArgumentList args) {}
	public void Transform(System.Xml.XPath.XPathNavigator input, XsltArgumentList args, System.Xml.XmlWriter output, System.Xml.XmlResolver resolver) {}
	public void Transform(System.Xml.XPath.XPathNavigator input, XsltArgumentList args, System.Xml.XmlWriter output) {}
	public void Transform(System.Xml.XPath.XPathNavigator input, XsltArgumentList args, System.IO.Stream output, System.Xml.XmlResolver resolver) {}
	public void Transform(System.Xml.XPath.XPathNavigator input, XsltArgumentList args, System.IO.Stream output) {}
	public void Transform(System.Xml.XPath.XPathNavigator input, XsltArgumentList args, System.IO.TextWriter output, System.Xml.XmlResolver resolver) {}
	public void Transform(System.Xml.XPath.XPathNavigator input, XsltArgumentList args, System.IO.TextWriter output) {}
	public System.Xml.XmlReader Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList args, System.Xml.XmlResolver resolver) {}
	public System.Xml.XmlReader Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList args) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList args, System.IO.TextWriter output, System.Xml.XmlResolver resolver) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList args, System.IO.TextWriter output) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList args, System.IO.Stream output, System.Xml.XmlResolver resolver) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList args, System.IO.Stream output) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList args, System.Xml.XmlWriter output, System.Xml.XmlResolver resolver) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList args, System.Xml.XmlWriter output) {}
	public void Transform(string inputfile, string outputfile, System.Xml.XmlResolver resolver) {}
	public void Transform(string inputfile, string outputfile) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlResolver XmlResolver { set{} }
}

