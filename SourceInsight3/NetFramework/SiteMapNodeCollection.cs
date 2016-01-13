public class SiteMapNodeCollection : System.Web.UI.IHierarchicalEnumerable, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
{

	// Constructors
	public SiteMapNodeCollection() {}
	public SiteMapNodeCollection(int capacity) {}
	public SiteMapNodeCollection(SiteMapNode value) {}
	public SiteMapNodeCollection(SiteMapNode[] value) {}
	public SiteMapNodeCollection(SiteMapNodeCollection value) {}

	// Methods
	public virtual int Add(SiteMapNode value) {}
	public virtual void AddRange(SiteMapNode[] value) {}
	public virtual void AddRange(SiteMapNodeCollection value) {}
	public virtual void Clear() {}
	public virtual bool Contains(SiteMapNode value) {}
	public virtual void CopyTo(SiteMapNode[] array, int index) {}
	public System.Web.UI.WebControls.SiteMapDataSourceView GetDataSourceView(System.Web.UI.WebControls.SiteMapDataSource owner, string viewName) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public System.Web.UI.WebControls.SiteMapHierarchicalDataSourceView GetHierarchicalDataSourceView() {}
	public virtual System.Web.UI.IHierarchyData GetHierarchyData(object enumeratedItem) {}
	public virtual int IndexOf(SiteMapNode value) {}
	public virtual void Insert(int index, SiteMapNode value) {}
	public static SiteMapNodeCollection ReadOnly(SiteMapNodeCollection collection) {}
	public virtual void Remove(SiteMapNode value) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public bool IsFixedSize { get{} }
	public bool IsReadOnly { get{} }
	public SiteMapNode Item { get{} set{} }
}

