public class WebPartVerb : System.Web.UI.IStateManager
{

	// Constructors
	public WebPartVerb(string id, WebPartEventHandler serverClickHandler) {}
	public WebPartVerb(string id, string clientClickHandler) {}
	public WebPartVerb(string id, WebPartEventHandler serverClickHandler, string clientClickHandler) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Checked { get{} set{} }
	public string ClientClickHandler { get{} }
	public string Description { get{} set{} }
	public bool Enabled { get{} set{} }
	public string ID { get{} }
	public string ImageUrl { get{} set{} }
	public WebPartEventHandler ServerClickHandler { get{} }
	public string Text { get{} set{} }
	public bool Visible { get{} set{} }
}

