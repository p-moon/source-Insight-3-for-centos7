public class RC2CryptoServiceProvider : RC2, System.IDisposable
{

	// Constructors
	public RC2CryptoServiceProvider() {}

	// Methods
	public virtual ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) {}
	public virtual ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) {}
	public virtual void GenerateKey() {}
	public virtual void GenerateIV() {}
	public void Clear() {}
	public bool ValidKeySize(int bitLength) {}
	public virtual ICryptoTransform CreateEncryptor() {}
	public virtual ICryptoTransform CreateDecryptor() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int EffectiveKeySize { get{} set{} }
	public bool UseSalt { get{} set{} }
	public int KeySize { get{} set{} }
	public int BlockSize { get{} set{} }
	public int FeedbackSize { get{} set{} }
	public byte[] IV { get{} set{} }
	public byte[] Key { get{} set{} }
	public KeySizes[] LegalBlockSizes { get{} }
	public KeySizes[] LegalKeySizes { get{} }
	public CipherMode Mode { get{} set{} }
	public PaddingMode Padding { get{} set{} }
}

