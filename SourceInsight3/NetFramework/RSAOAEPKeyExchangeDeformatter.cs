public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
{

	// Constructors
	public RSAOAEPKeyExchangeDeformatter() {}
	public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key) {}

	// Methods
	public virtual byte[] DecryptKeyExchange(byte[] rgbData) {}
	public virtual void SetKey(AsymmetricAlgorithm key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Parameters { get{} set{} }
}

