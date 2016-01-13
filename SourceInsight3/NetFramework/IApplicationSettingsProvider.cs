public interface IApplicationSettingsProvider
{

	// Methods
	public abstract virtual SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property) {}
	public abstract virtual void Reset(SettingsContext context) {}
	public abstract virtual void Upgrade(SettingsContext context, SettingsPropertyCollection properties) {}
}

