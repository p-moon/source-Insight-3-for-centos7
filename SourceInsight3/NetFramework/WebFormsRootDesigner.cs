public class WebFormsRootDesigner : System.ComponentModel.Design.IRootDesigner, System.ComponentModel.Design.IDesigner, System.IDisposable, System.ComponentModel.Design.IDesignerFilter
{

	// Methods
	public abstract virtual void AddClientScriptToDocument(ClientScriptItem scriptItem) {}
	public abstract virtual string AddControlToDocument(System.Web.UI.Control newControl, System.Web.UI.Control referenceControl, ControlLocation location) {}
	public virtual string GenerateEmptyDesignTimeHtml(System.Web.UI.Control control) {}
	public virtual string GenerateErrorDesignTimeHtml(System.Web.UI.Control control, System.Exception e, string errorMessage) {}
	public abstract virtual ClientScriptItemCollection GetClientScriptsInDocument() {}
	public virtual void Initialize(System.ComponentModel.IComponent component) {}
	public abstract virtual void RemoveClientScriptFromDocument(string clientScriptId) {}
	public abstract virtual void RemoveControlFromDocument(System.Web.UI.Control control) {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual void SetControlID(System.Web.UI.Control control, string id) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.IComponent Component { get{} set{} }
	public System.Globalization.CultureInfo CurrentCulture { get{} }
	public string DocumentUrl { get{} }
	public bool IsDesignerViewLocked { get{} }
	public bool IsLoading { get{} }
	public WebFormsReferenceManager ReferenceManager { get{} }

	// Events
	public event System.EventHandler LoadComplete;
}

