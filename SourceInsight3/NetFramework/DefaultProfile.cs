public class DefaultProfile : ProfileBase
{

	// Constructors
	public DefaultProfile() {}

	// Methods
	public object GetPropertyValue(string propertyName) {}
	public void SetPropertyValue(string propertyName, object propertyValue) {}
	public ProfileGroupBase GetProfileGroup(string groupName) {}
	public void Initialize(string username, bool isAuthenticated) {}
	public virtual void Save() {}
	public void Initialize(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection properties, System.Configuration.SettingsProviderCollection providers) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
	public string UserName { get{} }
	public bool IsAnonymous { get{} }
	public bool IsDirty { get{} }
	public System.DateTime LastActivityDate { get{} }
	public System.DateTime LastUpdatedDate { get{} }
	public System.Configuration.SettingsPropertyCollection Properties { get{} }
	public System.Configuration.SettingsProviderCollection Providers { get{} }
	public System.Configuration.SettingsPropertyValueCollection PropertyValues { get{} }
	public System.Configuration.SettingsContext Context { get{} }
	public bool IsSynchronized { get{} }
}

