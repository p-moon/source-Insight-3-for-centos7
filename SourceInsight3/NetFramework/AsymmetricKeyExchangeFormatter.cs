public class AsymmetricKeyExchangeFormatter
{

	// Methods
	public abstract virtual void SetKey(AsymmetricAlgorithm key) {}
	public abstract virtual byte[] CreateKeyExchange(byte[] data) {}
	public abstract virtual byte[] CreateKeyExchange(byte[] data, Type symAlgType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Parameters { get{} }
}

