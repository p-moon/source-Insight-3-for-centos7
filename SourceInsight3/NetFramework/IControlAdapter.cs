public interface IControlAdapter
{

	// Methods
	public abstract virtual void OnInit(System.EventArgs e) {}
	public abstract virtual void OnLoad(System.EventArgs e) {}
	public abstract virtual void OnPreRender(System.EventArgs e) {}
	public abstract virtual void Render(System.Web.UI.HtmlTextWriter writer) {}
	public abstract virtual void OnUnload(System.EventArgs e) {}
	public abstract virtual void CreateTemplatedUI(bool doDataBind) {}
	public abstract virtual bool HandlePostBackEvent(string eventArgument) {}
	public abstract virtual bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection, object controlPrivateDataout , System.Boolean& dataChanged) {}
	public abstract virtual void LoadAdapterState(object state) {}
	public abstract virtual object SaveAdapterState() {}

	// Properties
	public MobileControl Control { get{} set{} }
	public MobilePage Page { get{} }
	public int VisibleWeight { get{} }
	public int ItemWeight { get{} }
}

