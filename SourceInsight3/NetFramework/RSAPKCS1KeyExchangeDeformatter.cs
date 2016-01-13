public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
{

	// Constructors
	public RSAPKCS1KeyExchangeDeformatter() {}
	public RSAPKCS1KeyExchangeDeformatter(AsymmetricAlgorithm key) {}

	// Methods
	public virtual byte[] DecryptKeyExchange(byte[] rgbIn) {}
	public virtual void SetKey(AsymmetricAlgorithm key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RandomNumberGenerator RNG { get{} set{} }
	public string Parameters { get{} set{} }
}

