public interface IPageAdapter : IControlAdapter
{

	// Methods
	public abstract virtual System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer) {}
	public abstract virtual System.Collections.Specialized.NameValueCollection DeterminePostBackMode(System.Web.HttpRequest request, string postEventSourceID, string postEventArgumentID, System.Collections.Specialized.NameValueCollection baseCollection) {}
	public abstract virtual bool HandleError(System.Exception e, System.Web.UI.HtmlTextWriter writer) {}
	public abstract virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument) {}

	// Properties
	public MobilePage Page { get{} set{} }
	public int OptimumPageWeight { get{} }
	public System.Collections.IDictionary CookielessDataDictionary { get{} set{} }
	public bool PersistCookielessData { get{} set{} }
	public System.Collections.IList CacheVaryByHeaders { get{} }
}

