public class EncryptedXml
{

	// Constructors
	public EncryptedXml() {}
	public EncryptedXml(System.Xml.XmlDocument document) {}
	public EncryptedXml(System.Xml.XmlDocument document, System.Security.Policy.Evidence evidence) {}

	// Methods
	public virtual System.Xml.XmlElement GetIdElement(System.Xml.XmlDocument document, string idValue) {}
	public virtual byte[] GetDecryptionIV(EncryptedData encryptedData, string symmetricAlgorithmUri) {}
	public virtual System.Security.Cryptography.SymmetricAlgorithm GetDecryptionKey(EncryptedData encryptedData, string symmetricAlgorithmUri) {}
	public virtual byte[] DecryptEncryptedKey(EncryptedKey encryptedKey) {}
	public void AddKeyNameMapping(string keyName, object keyObject) {}
	public void ClearKeyNameMappings() {}
	public EncryptedData Encrypt(System.Xml.XmlElement inputElement, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) {}
	public EncryptedData Encrypt(System.Xml.XmlElement inputElement, string keyName) {}
	public void DecryptDocument() {}
	public byte[] EncryptData(byte[] plaintext, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) {}
	public byte[] EncryptData(System.Xml.XmlElement inputElement, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm, bool content) {}
	public byte[] DecryptData(EncryptedData encryptedData, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) {}
	public void ReplaceData(System.Xml.XmlElement inputElement, byte[] decryptedData) {}
	public static void ReplaceElement(System.Xml.XmlElement inputElement, EncryptedData encryptedData, bool content) {}
	public static byte[] EncryptKey(byte[] keyData, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) {}
	public static byte[] EncryptKey(byte[] keyData, System.Security.Cryptography.RSA rsa, bool useOAEP) {}
	public static byte[] DecryptKey(byte[] keyData, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) {}
	public static byte[] DecryptKey(byte[] keyData, System.Security.Cryptography.RSA rsa, bool useOAEP) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string XmlEncNamespaceUrl;
	public string XmlEncElementUrl;
	public string XmlEncElementContentUrl;
	public string XmlEncEncryptedKeyUrl;
	public string XmlEncDESUrl;
	public string XmlEncTripleDESUrl;
	public string XmlEncAES128Url;
	public string XmlEncAES256Url;
	public string XmlEncAES192Url;
	public string XmlEncRSA15Url;
	public string XmlEncRSAOAEPUrl;
	public string XmlEncTripleDESKeyWrapUrl;
	public string XmlEncAES128KeyWrapUrl;
	public string XmlEncAES256KeyWrapUrl;
	public string XmlEncAES192KeyWrapUrl;
	public string XmlEncSHA256Url;
	public string XmlEncSHA512Url;

	// Properties
	public System.Security.Policy.Evidence DocumentEvidence { get{} set{} }
	public System.Xml.XmlResolver Resolver { get{} set{} }
	public System.Security.Cryptography.PaddingMode Padding { get{} set{} }
	public System.Security.Cryptography.CipherMode Mode { get{} set{} }
	public System.Text.Encoding Encoding { get{} set{} }
	public string Recipient { get{} set{} }
}

