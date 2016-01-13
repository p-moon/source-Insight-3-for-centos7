public class SessionStateModule : System.Web.IHttpModule
{

	// Constructors
	public SessionStateModule() {}

	// Methods
	public virtual void Init(System.Web.HttpApplication app) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.EventHandler Start;
	public event System.EventHandler End;
}

