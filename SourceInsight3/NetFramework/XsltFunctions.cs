public class XsltFunctions
{

	// Methods
	public static bool StartsWith(string s1, string s2) {}
	public static bool Contains(string s1, string s2) {}
	public static string SubstringBefore(string s1, string s2) {}
	public static string SubstringAfter(string s1, string s2) {}
	public static string Substring(string value, double startIndex) {}
	public static string Substring(string value, double startIndex, double length) {}
	public static string NormalizeSpace(string value) {}
	public static string Translate(string arg, string mapString, string transString) {}
	public static bool Lang(string value, System.Xml.XPath.XPathNavigator context) {}
	public static double Round(double value) {}
	public static System.Xml.XPath.XPathItem SystemProperty(System.Xml.XmlQualifiedName name) {}
	public static string BaseUri(System.Xml.XPath.XPathNavigator navigator) {}
	public static string OuterXml(System.Xml.XPath.XPathNavigator navigator) {}
	public static string EXslObjectType(IList<System.Xml.XPath.XPathItem> value) {}
	public static double MSNumber(IList<System.Xml.XPath.XPathItem> value) {}
	public static string MSFormatDateTime(string dateTime, string format, string lang, bool isDate) {}
	public static double MSStringCompare(string s1, string s2, string lang, string options) {}
	public static string MSUtc(string dateTime) {}
	public static string MSLocalName(string name) {}
	public static string MSNamespaceUri(string name, System.Xml.XPath.XPathNavigator currentNode) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

