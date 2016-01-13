public interface IPostBackDataHandler
{

	// Methods
	public abstract virtual bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection) {}
	public abstract virtual void RaisePostDataChangedEvent() {}
}

