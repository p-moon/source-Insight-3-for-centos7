public class WebItem
{

	// Constructors
	public WebItem(string Name, WebClass AssociatedWebClass, string HtmlTemplateFilename) {}

	// Methods
	public void WriteTemplate(System.Web.HttpResponse Response, string HtmlTemplateFilename) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TagPrefix { get{} set{} }
	public bool ReScanReplacements { get{} set{} }
	public string Name { get{} }
}

