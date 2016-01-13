public class Activity
{

	// Constructors
	public Activity(ServiceConfig cfg) {}

	// Methods
	public void SynchronousCall(IServiceCall serviceCall) {}
	public void AsynchronousCall(IServiceCall serviceCall) {}
	public void BindToCurrentThread() {}
	public void UnbindFromThread() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

