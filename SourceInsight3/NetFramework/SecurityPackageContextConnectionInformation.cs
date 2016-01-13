public class SecurityPackageContextConnectionInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SecurityProtocol Protocol { get{} }
	public System.Security.Authentication.CipherAlgorithmType AlgorithmIdentifier { get{} }
	public int CipherStrength { get{} }
	public System.Security.Authentication.HashAlgorithmType Hash { get{} }
	public int HashStrength { get{} }
	public int KeyExchangeAlgorithm { get{} }
	public int ExchangeStrength { get{} }
}

