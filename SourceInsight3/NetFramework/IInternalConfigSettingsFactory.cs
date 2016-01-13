public interface IInternalConfigSettingsFactory
{

	// Methods
	public abstract virtual void SetConfigurationSystem(IInternalConfigSystem internalConfigSystem, bool initComplete) {}
	public abstract virtual void CompleteInit() {}
}

