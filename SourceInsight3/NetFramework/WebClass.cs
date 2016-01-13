public class WebClass
{

	// Constructors
	public WebClass(string UserWebClassName, string WebClassFileName, object ContainingClass) {}

	// Methods
	public string URLFor(WebItem obj, string EventName) {}
	public string URLFor(string objName, string EventName) {}
	public void ProcessEvents(System.Web.HttpRequest Request) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string UrlData { get{} set{} }
	public WebItem NextItem { get{} set{} }
	public string Name { get{} }
}

