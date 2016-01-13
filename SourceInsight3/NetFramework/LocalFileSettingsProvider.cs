public class LocalFileSettingsProvider : SettingsProvider, IApplicationSettingsProvider
{

	// Constructors
	public LocalFileSettingsProvider() {}

	// Methods
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection values) {}
	public virtual SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties) {}
	public virtual void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values) {}
	public virtual void Reset(SettingsContext context) {}
	public virtual void Upgrade(SettingsContext context, SettingsPropertyCollection properties) {}
	public virtual SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string Name { get{} }
	public string Description { get{} }
}

