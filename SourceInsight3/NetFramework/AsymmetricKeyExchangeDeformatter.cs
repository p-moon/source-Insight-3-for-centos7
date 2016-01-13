public class AsymmetricKeyExchangeDeformatter
{

	// Methods
	public abstract virtual void SetKey(AsymmetricAlgorithm key) {}
	public abstract virtual byte[] DecryptKeyExchange(byte[] rgb) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Parameters { get{} set{} }
}

