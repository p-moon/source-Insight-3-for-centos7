public class DES : SymmetricAlgorithm, System.IDisposable
{

	// Methods
	public static DES Create() {}
	public static DES Create(string algName) {}
	public static bool IsWeakKey(byte[] rgbKey) {}
	public static bool IsSemiWeakKey(byte[] rgbKey) {}
	public void Clear() {}
	public bool ValidKeySize(int bitLength) {}
	public virtual ICryptoTransform CreateEncryptor() {}
	public abstract virtual ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) {}
	public virtual ICryptoTransform CreateDecryptor() {}
	public abstract virtual ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) {}
	public abstract virtual void GenerateKey() {}
	public abstract virtual void GenerateIV() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public byte[] Key { get{} set{} }
	public int BlockSize { get{} set{} }
	public int FeedbackSize { get{} set{} }
	public byte[] IV { get{} set{} }
	public KeySizes[] LegalBlockSizes { get{} }
	public KeySizes[] LegalKeySizes { get{} }
	public int KeySize { get{} set{} }
	public CipherMode Mode { get{} set{} }
	public PaddingMode Padding { get{} set{} }
}

