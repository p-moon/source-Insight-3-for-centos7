public class AsymmetricAlgorithm : System.IDisposable
{

	// Methods
	public void Clear() {}
	public static AsymmetricAlgorithm Create() {}
	public static AsymmetricAlgorithm Create(string algName) {}
	public abstract virtual void FromXmlString(string xmlString) {}
	public abstract virtual string ToXmlString(bool includePrivateParameters) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int KeySize { get{} set{} }
	public KeySizes[] LegalKeySizes { get{} }
	public string SignatureAlgorithm { get{} }
	public string KeyExchangeAlgorithm { get{} }
}

