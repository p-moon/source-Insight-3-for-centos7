public class PageAsyncTask
{

	// Constructors
	public PageAsyncTask(System.Web.BeginEventHandler beginHandler, System.Web.EndEventHandler endHandler, System.Web.EndEventHandler timeoutHandler, object state) {}
	public PageAsyncTask(System.Web.BeginEventHandler beginHandler, System.Web.EndEventHandler endHandler, System.Web.EndEventHandler timeoutHandler, object state, bool executeInParallel) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.BeginEventHandler BeginHandler { get{} }
	public System.Web.EndEventHandler EndHandler { get{} }
	public System.Web.EndEventHandler TimeoutHandler { get{} }
	public object State { get{} }
	public bool ExecuteInParallel { get{} }
}

