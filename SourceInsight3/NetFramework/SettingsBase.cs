public class SettingsBase
{

	// Methods
	public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers) {}
	public virtual void Save() {}
	public static SettingsBase Synchronized(SettingsBase settingsBase) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
	public SettingsPropertyCollection Properties { get{} }
	public SettingsProviderCollection Providers { get{} }
	public SettingsPropertyValueCollection PropertyValues { get{} }
	public SettingsContext Context { get{} }
	public bool IsSynchronized { get{} }
}

