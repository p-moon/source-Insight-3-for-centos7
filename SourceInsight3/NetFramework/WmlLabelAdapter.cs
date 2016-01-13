public class WmlLabelAdapter : WmlControlAdapter, System.Web.UI.MobileControls.IControlAdapter
{

	// Constructors
	public WmlLabelAdapter() {}

	// Methods
	public virtual void Render(WmlMobileTextWriter writer) {}
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
	public System.Web.UI.MobileControls.MobileControl Control { get{} set{} }
	public System.Web.UI.MobileControls.MobilePage Page { get{} set{} }
	public System.Web.Mobile.MobileCapabilities Device { get{} }
	public System.Web.UI.MobileControls.Style Style { get{} }
	public int VisibleWeight { get{} }
	public int ItemWeight { get{} }
}

