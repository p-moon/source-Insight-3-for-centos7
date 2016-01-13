public class ApplicationSettingsBase : SettingsBase, System.ComponentModel.INotifyPropertyChanged
{

	// Methods
	public object GetPreviousVersion(string propertyName) {}
	public void Reload() {}
	public void Reset() {}
	public virtual void Save() {}
	public virtual void Upgrade() {}
	public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SettingsContext Context { get{} }
	public SettingsPropertyCollection Properties { get{} }
	public SettingsPropertyValueCollection PropertyValues { get{} }
	public SettingsProviderCollection Providers { get{} }
	public string SettingsKey { get{} set{} }
	public object Item { get{} set{} }
	public bool IsSynchronized { get{} }

	// Events
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	public event System.Configuration.SettingChangingEventHandler SettingChanging;
	public event System.Configuration.SettingsLoadedEventHandler SettingsLoaded;
	public event System.Configuration.SettingsSavingEventHandler SettingsSaving;
}

