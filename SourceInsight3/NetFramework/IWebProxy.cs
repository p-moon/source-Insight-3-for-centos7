public interface IWebProxy
{

	// Methods
	public abstract virtual System.Uri GetProxy(System.Uri destination) {}
	public abstract virtual bool IsBypassed(System.Uri host) {}

	// Properties
	public ICredentials Credentials { get{} set{} }
}

