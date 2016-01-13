public class XsltLibrary
{

	// Methods
	public string FormatMessage(string res, IList<string> args) {}
	public int CheckScriptNamespace(string nsUri) {}
	public bool ElementAvailable(System.Xml.XmlQualifiedName name) {}
	public bool FunctionAvailable(System.Xml.XmlQualifiedName name) {}
	public int RegisterDecimalFormat(System.Xml.XmlQualifiedName name, string infinitySymbol, string nanSymbol, string characters) {}
	public double RegisterDecimalFormatter(string formatPicture, string infinitySymbol, string nanSymbol, string characters) {}
	public string FormatNumberStatic(double value, double decimalFormatterIndex) {}
	public string FormatNumberDynamic(double value, string formatPicture, System.Xml.XmlQualifiedName decimalFormatName, string errorMessageName) {}
	public string NumberFormat(IList<System.Xml.XPath.XPathItem> value, string formatString, double lang, string letterValue, string groupingSeparator, double groupingSize) {}
	public int LangToLcid(string lang, bool forwardCompatibility) {}
	public bool EqualityOperator(double opCode, IList<System.Xml.XPath.XPathItem> left, IList<System.Xml.XPath.XPathItem> right) {}
	public bool RelationalOperator(double opCode, IList<System.Xml.XPath.XPathItem> left, IList<System.Xml.XPath.XPathItem> right) {}
	public bool IsSameNodeSort(System.Xml.XPath.XPathNavigator nav1, System.Xml.XPath.XPathNavigator nav2) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

