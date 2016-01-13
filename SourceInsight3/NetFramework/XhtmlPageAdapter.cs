public class XhtmlPageAdapter : XhtmlControlAdapter, System.Web.UI.MobileControls.IControlAdapter, System.Web.UI.MobileControls.IPageAdapter
{

	// Constructors
	public XhtmlPageAdapter() {}

	// Methods
	public virtual System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer) {}
	public virtual System.Collections.Specialized.NameValueCollection DeterminePostBackMode(System.Web.HttpRequest request, string postEventSourceID, string postEventArgumentID, System.Collections.Specialized.NameValueCollection baseCollection) {}
	public static bool DeviceQualifies(System.Web.HttpContext context) {}
	public virtual bool HandleError(System.Exception e, System.Web.UI.HtmlTextWriter writer) {}
	public virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument) {}
	public virtual void OnPreRender(System.EventArgs e) {}
	public virtual void Render(XhtmlMobileTextWriter writer) {}
	public virtual void RenderUrlPostBackEvent(XhtmlMobileTextWriter writer, string target, string argument) {}
	public virtual void Render(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void LoadAdapterState(object state) {}
	public virtual object SaveAdapterState() {}
	public virtual void OnInit(System.EventArgs e) {}
	public virtual void OnLoad(System.EventArgs e) {}
	public virtual void OnUnload(System.EventArgs e) {}
	public virtual bool HandlePostBackEvent(string eventArgument) {}
	public virtual bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data, object controlPrivateDataout , System.Boolean& dataChanged) {}
	public virtual void CreateTemplatedUI(bool doDataBind) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.IList CacheVaryByHeaders { get{} }
	public System.Collections.IDictionary CookielessDataDictionary { get{} set{} }
	public string EventArgumentKey { get{} }
	public string EventSourceKey { get{} }
	public int OptimumPageWeight { get{} }
	public System.Web.UI.MobileControls.MobilePage Page { get{} set{} }
	public bool PersistCookielessData { get{} set{} }
	public System.Web.UI.MobileControls.MobileControl Control { get{} set{} }
	public System.Web.Mobile.MobileCapabilities Device { get{} }
	public System.Web.UI.MobileControls.Style Style { get{} }
	public int VisibleWeight { get{} }
	public int ItemWeight { get{} }
}

