public class RemoteWebConfigurationHostServer : IRemoteWebConfigurationHostServer
{

	// Constructors
	public RemoteWebConfigurationHostServer() {}

	// Methods
	public virtual byte[] GetData(string fileName, bool getReadTimeOnlyout , System.Int64& readTime) {}
	public virtual void WriteData(string fileName, string templateFileName, byte[] data, System.Int64& readTime) {}
	public virtual string GetFilePaths(int webLevelAsInt, string path, string site, string locationSubPath) {}
	public virtual string DoEncryptOrDecrypt(bool doEncrypt, string xmlString, string protectionProviderName, string protectionProviderType, string[] paramKeys, string[] paramValues) {}
	public virtual void GetFileDetails(string nameout , System.Boolean& existsout , System.Int64& sizeout , System.Int64& createDateout , System.Int64& lastWriteDate) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

