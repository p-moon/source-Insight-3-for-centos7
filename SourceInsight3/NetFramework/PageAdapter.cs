public class PageAdapter : ControlAdapter
{

	// Methods
	public virtual System.Collections.Specialized.NameValueCollection DeterminePostBackMode() {}
	public virtual System.Collections.ICollection GetRadioButtonsByGroup(string groupName) {}
	public virtual System.Web.UI.PageStatePersister GetStatePersister() {}
	public virtual void RegisterRadioButton(System.Web.UI.WebControls.RadioButton radioButton) {}
	public virtual void RenderBeginHyperlink(System.Web.UI.HtmlTextWriter writer, string targetUrl, bool encodeUrl, string softkeyLabel) {}
	public virtual void RenderBeginHyperlink(System.Web.UI.HtmlTextWriter writer, string targetUrl, bool encodeUrl, string softkeyLabel, string accessKey) {}
	public virtual void RenderEndHyperlink(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void RenderPostBackEvent(System.Web.UI.HtmlTextWriter writer, string target, string argument, string softkeyLabel, string text) {}
	public virtual void RenderPostBackEvent(System.Web.UI.HtmlTextWriter writer, string target, string argument, string softkeyLabel, string text, string postUrl, string accessKey) {}
	public virtual string TransformText(string text) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.StringCollection CacheVaryByHeaders { get{} }
	public System.Collections.Specialized.StringCollection CacheVaryByParams { get{} }
}

