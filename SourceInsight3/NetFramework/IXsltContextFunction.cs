public interface IXsltContextFunction
{

	// Methods
	public abstract virtual object Invoke(XsltContext xsltContext, object[] args, System.Xml.XPath.XPathNavigator docContext) {}

	// Properties
	public int Minargs { get{} }
	public int Maxargs { get{} }
	public System.Xml.XPath.XPathResultType ReturnType { get{} }
	public System.Xml.XPath.XPathResultType[] ArgTypes { get{} }
}

