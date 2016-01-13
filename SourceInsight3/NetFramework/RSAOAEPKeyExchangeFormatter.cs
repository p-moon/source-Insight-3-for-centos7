public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
{

	// Constructors
	public RSAOAEPKeyExchangeFormatter() {}
	public RSAOAEPKeyExchangeFormatter(AsymmetricAlgorithm key) {}

	// Methods
	public virtual void SetKey(AsymmetricAlgorithm key) {}
	public virtual byte[] CreateKeyExchange(byte[] rgbData) {}
	public virtual byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public byte[] Parameter { get{} set{} }
	public string Parameters { get{} }
	public RandomNumberGenerator Rng { get{} set{} }
}

