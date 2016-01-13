public interface IRemoteWebConfigurationHostServer
{

	// Methods
	public abstract virtual byte[] GetData(string fileName, bool getReadTimeOnlyout , System.Int64& readTime) {}
	public abstract virtual void WriteData(string fileName, string templateFileName, byte[] data, System.Int64& readTime) {}
	public abstract virtual string GetFilePaths(int webLevel, string path, string site, string locationSubPath) {}
	public abstract virtual string DoEncryptOrDecrypt(bool doEncrypt, string xmlString, string protectionProviderName, string protectionProviderType, string[] parameterKeys, string[] parameterValues) {}
	public abstract virtual void GetFileDetails(string nameout , System.Boolean& existsout , System.Int64& sizeout , System.Int64& createDateout , System.Int64& lastWriteDate) {}
}

