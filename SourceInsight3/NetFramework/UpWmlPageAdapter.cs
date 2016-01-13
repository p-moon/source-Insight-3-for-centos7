public class UpWmlPageAdapter : WmlPageAdapter, System.Web.UI.MobileControls.IControlAdapter, System.Web.UI.MobileControls.IPageAdapter
{

	// Constructors
	public UpWmlPageAdapter() {}

	// Methods
	public static bool DeviceQualifies(System.Web.HttpContext context) {}
	public virtual System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer) {}
	public virtual System.Collections.Specialized.NameValueCollection DeterminePostBackMode(System.Web.HttpRequest request, string postEventSourceID, string postEventArgumentID, System.Collections.Specialized.NameValueCollection baseCollection) {}
	public virtual bool HandleError(System.Exception e, System.Web.UI.HtmlTextWriter writer) {}
	public virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument) {}
	public virtual void Render(WmlMobileTextWriter writer) {}
	public virtual bool IsFormRendered(System.Web.UI.MobileControls.Form form) {}
	public virtual bool RendersMultipleForms() {}
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
	public System.Web.UI.MobileControls.MobilePage Page { get{} set{} }
	public System.Collections.IDictionary CookielessDataDictionary { get{} set{} }
	public bool PersistCookielessData { get{} set{} }
	public int OptimumPageWeight { get{} }
	public System.Collections.IList CacheVaryByHeaders { get{} }
	public System.Web.UI.MobileControls.MobileControl Control { get{} set{} }
	public System.Web.Mobile.MobileCapabilities Device { get{} }
	public System.Web.UI.MobileControls.Style Style { get{} }
	public int VisibleWeight { get{} }
	public int ItemWeight { get{} }
}

