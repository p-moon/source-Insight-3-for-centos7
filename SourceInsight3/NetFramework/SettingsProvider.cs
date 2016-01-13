public class SettingsProvider : System.Configuration.Provider.ProviderBase
{

	// Methods
	public abstract virtual SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection) {}
	public abstract virtual void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string Name { get{} }
	public string Description { get{} }
}

