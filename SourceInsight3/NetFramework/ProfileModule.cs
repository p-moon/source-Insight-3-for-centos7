public class ProfileModule : System.Web.IHttpModule
{

	// Constructors
	public ProfileModule() {}

	// Methods
	public virtual void Dispose() {}
	public virtual void Init(System.Web.HttpApplication app) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.Web.Profile.ProfileEventHandler Personalize;
	public event System.Web.Profile.ProfileMigrateEventHandler MigrateAnonymous;
	public event System.Web.Profile.ProfileAutoSaveEventHandler ProfileAutoSaving;
}

