public interface IWebProxyScript
{

	// Methods
	public abstract virtual bool Load(System.Uri scriptLocation, string script, Type helperType) {}
	public abstract virtual string Run(string url, string host) {}
	public abstract virtual void Close() {}
}

