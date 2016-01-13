public interface IAuthorizeRemotingConnection
{

	// Methods
	public abstract virtual bool IsConnectingEndPointAuthorized(System.Net.EndPoint endPoint) {}
	public abstract virtual bool IsConnectingIdentityAuthorized(System.Security.Principal.IIdentity identity) {}
}

