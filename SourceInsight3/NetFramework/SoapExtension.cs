public class SoapExtension
{

	// Methods
	public abstract virtual object GetInitializer(LogicalMethodInfo methodInfo, SoapExtensionAttribute attribute) {}
	public abstract virtual object GetInitializer(Type serviceType) {}
	public abstract virtual void Initialize(object initializer) {}
	public abstract virtual void ProcessMessage(SoapMessage message) {}
	public virtual System.IO.Stream ChainStream(System.IO.Stream stream) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

