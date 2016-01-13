public class SiteMapHierarchicalDataSourceView : System.Web.UI.HierarchicalDataSourceView
{

	// Constructors
	public SiteMapHierarchicalDataSourceView(System.Web.SiteMapNode node) {}
	public SiteMapHierarchicalDataSourceView(System.Web.SiteMapNodeCollection collection) {}

	// Methods
	public virtual System.Web.UI.IHierarchicalEnumerable Select() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

