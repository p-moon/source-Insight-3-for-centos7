public class ProfileAutoSaveEventArgs : System.EventArgs
{

	// Constructors
	public ProfileAutoSaveEventArgs(System.Web.HttpContext context) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.HttpContext Context { get{} }
	public bool ContinueWithProfileAutoSave { get{} set{} }
}

