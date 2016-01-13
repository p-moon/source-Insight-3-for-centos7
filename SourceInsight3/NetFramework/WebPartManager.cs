public class WebPartManager : System.Web.UI.Control, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.INamingContainer, IPersonalizable
{

	// Constructors
	public WebPartManager() {}

	// Methods
	public WebPart AddWebPart(WebPart webPart, WebPartZoneBase zone, int zoneIndex) {}
	public virtual void BeginWebPartConnecting(WebPart webPart) {}
	public virtual void BeginWebPartEditing(WebPart webPart) {}
	public bool CanConnectWebParts(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint) {}
	public virtual bool CanConnectWebParts(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint, WebPartTransformer transformer) {}
	public void CloseWebPart(WebPart webPart) {}
	public WebPartConnection ConnectWebParts(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint) {}
	public virtual WebPartConnection ConnectWebParts(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint, WebPartTransformer transformer) {}
	public virtual GenericWebPart CreateWebPart(System.Web.UI.Control control) {}
	public void DeleteWebPart(WebPart webPart) {}
	public virtual void DisconnectWebParts(WebPartConnection connection) {}
	public virtual void EndWebPartConnecting() {}
	public virtual void EndWebPartEditing() {}
	public virtual void ExportWebPart(WebPart webPart, System.Xml.XmlWriter writer) {}
	public virtual void Focus() {}
	public virtual ConsumerConnectionPointCollection GetConsumerConnectionPoints(WebPart webPart) {}
	public static WebPartManager GetCurrentWebPartManager(System.Web.UI.Page page) {}
	public string GetExportUrl(WebPart webPart) {}
	public GenericWebPart GetGenericWebPart(System.Web.UI.Control control) {}
	public virtual ProviderConnectionPointCollection GetProviderConnectionPoints(WebPart webPart) {}
	public virtual WebPart ImportWebPart(System.Xml.XmlReader readerout , System.String& errorMessage) {}
	public virtual bool IsAuthorized(Type type, string path, string authorizationFilter, bool isShared) {}
	public bool IsAuthorized(WebPart webPart) {}
	public virtual void MoveWebPart(WebPart webPart, WebPartZoneBase zone, int zoneIndex) {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public virtual void DataBind() {}
	public virtual void RenderControl(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public virtual System.Web.UI.Control FindControl(string id) {}
	public virtual bool HasControls() {}
	public void SetRenderMethodDelegate(System.Web.UI.RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public WebPartDisplayMode CatalogDisplayMode;
	public WebPartDisplayMode ConnectDisplayMode;
	public WebPartDisplayMode DesignDisplayMode;
	public WebPartDisplayMode EditDisplayMode;
	public WebPartDisplayMode BrowseDisplayMode;

	// Properties
	public TransformerTypeCollection AvailableTransformers { get{} }
	public string CloseProviderWarning { get{} set{} }
	public WebPartConnectionCollection Connections { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public string DeleteWarning { get{} set{} }
	public WebPartDisplayMode DisplayMode { get{} set{} }
	public WebPartDisplayModeCollection DisplayModes { get{} }
	public bool EnableClientScript { get{} set{} }
	public bool EnableTheming { get{} set{} }
	public string ExportSensitiveDataWarning { get{} set{} }
	public WebPartPersonalization Personalization { get{} }
	public WebPart SelectedWebPart { get{} }
	public string SkinID { get{} set{} }
	public WebPartConnectionCollection StaticConnections { get{} }
	public WebPartDisplayModeCollection SupportedDisplayModes { get{} }
	public bool Visible { get{} set{} }
	public WebPartCollection WebParts { get{} }
	public WebPartZoneCollection Zones { get{} }
	public string ClientID { get{} }
	public string ID { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public System.Web.UI.Control NamingContainer { get{} }
	public System.Web.UI.Control BindingContainer { get{} }
	public System.Web.UI.Page Page { get{} set{} }
	public System.Web.UI.TemplateControl TemplateControl { get{} set{} }
	public System.Web.UI.Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public string UniqueID { get{} }

	// Events
	public event System.Web.UI.WebControls.WebParts.WebPartAuthorizationEventHandler AuthorizeWebPart;
	public event System.EventHandler ConnectionsActivated;
	public event System.EventHandler ConnectionsActivating;
	public event System.Web.UI.WebControls.WebParts.WebPartDisplayModeEventHandler DisplayModeChanged;
	public event System.Web.UI.WebControls.WebParts.WebPartDisplayModeCancelEventHandler DisplayModeChanging;
	public event System.Web.UI.WebControls.WebParts.WebPartEventHandler SelectedWebPartChanged;
	public event System.Web.UI.WebControls.WebParts.WebPartCancelEventHandler SelectedWebPartChanging;
	public event System.Web.UI.WebControls.WebParts.WebPartEventHandler WebPartAdded;
	public event System.Web.UI.WebControls.WebParts.WebPartAddingEventHandler WebPartAdding;
	public event System.Web.UI.WebControls.WebParts.WebPartEventHandler WebPartClosed;
	public event System.Web.UI.WebControls.WebParts.WebPartCancelEventHandler WebPartClosing;
	public event System.Web.UI.WebControls.WebParts.WebPartEventHandler WebPartDeleted;
	public event System.Web.UI.WebControls.WebParts.WebPartCancelEventHandler WebPartDeleting;
	public event System.Web.UI.WebControls.WebParts.WebPartEventHandler WebPartMoved;
	public event System.Web.UI.WebControls.WebParts.WebPartMovingEventHandler WebPartMoving;
	public event System.Web.UI.WebControls.WebParts.WebPartConnectionsEventHandler WebPartsConnected;
	public event System.Web.UI.WebControls.WebParts.WebPartConnectionsCancelEventHandler WebPartsConnecting;
	public event System.Web.UI.WebControls.WebParts.WebPartConnectionsEventHandler WebPartsDisconnected;
	public event System.Web.UI.WebControls.WebParts.WebPartConnectionsCancelEventHandler WebPartsDisconnecting;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}

