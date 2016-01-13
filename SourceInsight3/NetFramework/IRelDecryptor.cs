public interface IRelDecryptor
{

	// Methods
	public abstract virtual System.IO.Stream Decrypt(EncryptionMethod encryptionMethod, KeyInfo keyInfo, System.IO.Stream toDecrypt) {}
}

