public class SiteMapNode : System.ICloneable, System.Web.UI.IHierarchyData, System.Web.UI.INavigateUIData
{

	// Constructors
	public SiteMapNode(SiteMapProvider provider, string key) {}
	public SiteMapNode(SiteMapProvider provider, string key, string url) {}
	public SiteMapNode(SiteMapProvider provider, string key, string url, string title) {}
	public SiteMapNode(SiteMapProvider provider, string key, string url, string title, string description) {}
	public SiteMapNode(SiteMapProvider provider, string key, string url, string title, string description, System.Collections.IList roles, System.Collections.Specialized.NameValueCollection attributes, System.Collections.Specialized.NameValueCollection explicitResourceKeys, string implicitResourceKey) {}

	// Methods
	public virtual SiteMapNode Clone() {}
	public virtual SiteMapNode Clone(bool cloneParentNodes) {}
	public virtual bool Equals(object obj) {}
	public SiteMapNodeCollection GetAllNodes() {}
	public System.Web.UI.WebControls.SiteMapDataSourceView GetDataSourceView(System.Web.UI.WebControls.SiteMapDataSource owner, string viewName) {}
	public System.Web.UI.WebControls.SiteMapHierarchicalDataSourceView GetHierarchicalDataSourceView() {}
	public virtual int GetHashCode() {}
	public virtual bool IsAccessibleToUser(HttpContext context) {}
	public virtual bool IsDescendantOf(SiteMapNode node) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Item { get{} set{} }
	public SiteMapNodeCollection ChildNodes { get{} set{} }
	public string Description { get{} set{} }
	public string Key { get{} }
	public bool HasChildNodes { get{} }
	public SiteMapNode NextSibling { get{} }
	public SiteMapNode ParentNode { get{} set{} }
	public SiteMapNode PreviousSibling { get{} }
	public SiteMapProvider Provider { get{} }
	public bool ReadOnly { get{} set{} }
	public string ResourceKey { get{} set{} }
	public System.Collections.IList Roles { get{} set{} }
	public SiteMapNode RootNode { get{} }
	public string Title { get{} set{} }
	public string Url { get{} set{} }
}

