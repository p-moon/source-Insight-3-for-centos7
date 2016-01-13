public class ProvidersHelper
{

	// Methods
	public static System.Configuration.Provider.ProviderBase InstantiateProvider(System.Configuration.ProviderSettings providerSettings, Type providerType) {}
	public static void InstantiateProviders(System.Configuration.ProviderSettingsCollection configProviders, System.Configuration.Provider.ProviderCollection providers, Type providerType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

