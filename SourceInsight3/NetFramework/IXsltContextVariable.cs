public interface IXsltContextVariable
{

	// Methods
	public abstract virtual object Evaluate(XsltContext xsltContext) {}

	// Properties
	public bool IsLocal { get{} }
	public bool IsParam { get{} }
	public System.Xml.XPath.XPathResultType VariableType { get{} }
}

