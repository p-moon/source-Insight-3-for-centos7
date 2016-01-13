public interface IInternalConfigConfigurationFactory
{

	// Methods
	public abstract virtual System.Configuration.Configuration Create(Type typeConfigHost, object[] hostInitConfigurationParams) {}
	public abstract virtual string NormalizeLocationSubPath(string subPath, IConfigErrorInfo errorInfo) {}
}

