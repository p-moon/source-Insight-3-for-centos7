public interface IPersistComponentSettings
{

	// Methods
	public abstract virtual void LoadComponentSettings() {}
	public abstract virtual void SaveComponentSettings() {}
	public abstract virtual void ResetComponentSettings() {}

	// Properties
	public bool SaveSettings { get{} set{} }
	public string SettingsKey { get{} set{} }
}

