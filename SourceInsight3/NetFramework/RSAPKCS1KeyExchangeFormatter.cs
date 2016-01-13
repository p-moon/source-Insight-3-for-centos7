public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
{

	// Constructors
	public RSAPKCS1KeyExchangeFormatter() {}
	public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key) {}

	// Methods
	public virtual void SetKey(AsymmetricAlgorithm key) {}
	public virtual byte[] CreateKeyExchange(byte[] rgbData) {}
	public virtual byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Parameters { get{} }
	public RandomNumberGenerator Rng { get{} set{} }
}

