public class ChtmlPageAdapter : HtmlPageAdapter, System.Web.UI.MobileControls.IControlAdapter, System.Web.UI.MobileControls.IPageAdapter
{

	// Constructors
	public ChtmlPageAdapter() {}

	// Methods
	public static bool DeviceQualifies(System.Web.HttpContext context) {}
	public virtual void RenderPostBackEvent(HtmlMobileTextWriter writer, string target, string argument) {}
	public virtual void RenderPostBackHeader(HtmlMobileTextWriter writer, System.Web.UI.MobileControls.Form form) {}
	public virtual System.Collections.Specialized.NameValueCollection DeterminePostBackMode(System.Web.HttpRequest request, string postEventSourceID, string postEventArgumentID, System.Collections.Specialized.NameValueCollection baseCollection) {}
	public virtual System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer) {}
	public virtual void Render(HtmlMobileTextWriter writer) {}
	public virtual void RenderForm(HtmlMobileTextWriter writer, System.Web.UI.MobileControls.Form form) {}
	public virtual bool IsFormRendered(System.Web.UI.MobileControls.Form form) {}
	public string GetFormUrl(System.Web.UI.MobileControls.Form form) {}
	public virtual void RenderUrlPostBackEvent(HtmlMobileTextWriter writer, string target, string argument) {}
	public virtual bool HandleError(System.Exception e, System.Web.UI.HtmlTextWriter writer) {}
	public virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument) {}
	public virtual void Render(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void LoadAdapterState(object state) {}
	public virtual object SaveAdapterState() {}
	public virtual void OnInit(System.EventArgs e) {}
	public virtual void OnLoad(System.EventArgs e) {}
	public virtual void OnPreRender(System.EventArgs e) {}
	public virtual void OnUnload(System.EventArgs e) {}
	public virtual bool HandlePostBackEvent(string eventArgument) {}
	public virtual bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data, object controlPrivateDataout , System.Boolean& dataChanged) {}
	public virtual void CreateTemplatedUI(bool doDataBind) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int OptimumPageWeight { get{} }
	public System.Web.UI.MobileControls.MobilePage Page { get{} set{} }
	public System.Collections.IDictionary CookielessDataDictionary { get{} set{} }
	public bool PersistCookielessData { get{} set{} }
	public System.Collections.IList CacheVaryByHeaders { get{} }
	public bool RequiresFormTag { get{} }
	public System.Web.UI.MobileControls.MobileControl Control { get{} set{} }
	public System.Web.Mobile.MobileCapabilities Device { get{} }
	public System.Web.UI.MobileControls.Style Style { get{} }
	public int VisibleWeight { get{} }
	public int ItemWeight { get{} }
}

