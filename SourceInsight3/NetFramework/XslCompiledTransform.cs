public class XslCompiledTransform
{

	// Constructors
	public XslCompiledTransform() {}
	public XslCompiledTransform(bool enableDebug) {}

	// Methods
	public void Load(System.Xml.XmlReader stylesheet) {}
	public void Load(System.Xml.XmlReader stylesheet, XsltSettings settings, System.Xml.XmlResolver stylesheetResolver) {}
	public void Load(System.Xml.XPath.IXPathNavigable stylesheet) {}
	public void Load(System.Xml.XPath.IXPathNavigable stylesheet, XsltSettings settings, System.Xml.XmlResolver stylesheetResolver) {}
	public void Load(string stylesheetUri) {}
	public void Load(string stylesheetUri, XsltSettings settings, System.Xml.XmlResolver stylesheetResolver) {}
	public static System.CodeDom.Compiler.CompilerErrorCollection CompileToType(System.Xml.XmlReader stylesheet, XsltSettings settings, System.Xml.XmlResolver stylesheetResolver, bool debug, System.Reflection.Emit.TypeBuilder typeBuilder, string scriptAssemblyPath) {}
	public void Load(Type compiledStylesheet) {}
	public void Load(System.Reflection.MethodInfo executeMethod, byte[] queryData, Type[] earlyBoundTypes) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.XmlWriter results) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList arguments, System.Xml.XmlWriter results) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList arguments, System.IO.TextWriter results) {}
	public void Transform(System.Xml.XPath.IXPathNavigable input, XsltArgumentList arguments, System.IO.Stream results) {}
	public void Transform(System.Xml.XmlReader input, System.Xml.XmlWriter results) {}
	public void Transform(System.Xml.XmlReader input, XsltArgumentList arguments, System.Xml.XmlWriter results) {}
	public void Transform(System.Xml.XmlReader input, XsltArgumentList arguments, System.IO.TextWriter results) {}
	public void Transform(System.Xml.XmlReader input, XsltArgumentList arguments, System.IO.Stream results) {}
	public void Transform(System.Xml.XmlReader input, XsltArgumentList arguments, System.Xml.XmlWriter results, System.Xml.XmlResolver documentResolver) {}
	public void Transform(string inputUri, string resultsFile) {}
	public void Transform(string inputUri, System.Xml.XmlWriter results) {}
	public void Transform(string inputUri, XsltArgumentList arguments, System.Xml.XmlWriter results) {}
	public void Transform(string inputUri, XsltArgumentList arguments, System.IO.TextWriter results) {}
	public void Transform(string inputUri, XsltArgumentList arguments, System.IO.Stream results) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlWriterSettings OutputSettings { get{} }
	public System.CodeDom.Compiler.TempFileCollection TemporaryFiles { get{} }
}

