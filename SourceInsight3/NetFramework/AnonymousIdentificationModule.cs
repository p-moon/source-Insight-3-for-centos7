public class AnonymousIdentificationModule : System.Web.IHttpModule
{

	// Constructors
	public AnonymousIdentificationModule() {}

	// Methods
	public static void ClearAnonymousIdentifier() {}
	public virtual void Dispose() {}
	public virtual void Init(System.Web.HttpApplication app) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Enabled { get{} }

	// Events
	public event System.Web.Security.AnonymousIdentificationEventHandler Creating;
}

