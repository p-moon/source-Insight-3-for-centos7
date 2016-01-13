public class SignatureDescription
{

	// Constructors
	public SignatureDescription() {}
	public SignatureDescription(System.Security.SecurityElement el) {}

	// Methods
	public virtual AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key) {}
	public virtual AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key) {}
	public virtual HashAlgorithm CreateDigest() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string KeyAlgorithm { get{} set{} }
	public string DigestAlgorithm { get{} set{} }
	public string FormatterAlgorithm { get{} set{} }
	public string DeformatterAlgorithm { get{} set{} }
}

