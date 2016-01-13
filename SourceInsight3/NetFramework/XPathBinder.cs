public class XPathBinder
{

	// Methods
	public static object Eval(object container, string xPath) {}
	public static object Eval(object container, string xPath, System.Xml.IXmlNamespaceResolver resolver) {}
	public static string Eval(object container, string xPath, string format) {}
	public static string Eval(object container, string xPath, string format, System.Xml.IXmlNamespaceResolver resolver) {}
	public static System.Collections.IEnumerable Select(object container, string xPath) {}
	public static System.Collections.IEnumerable Select(object container, string xPath, System.Xml.IXmlNamespaceResolver resolver) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

