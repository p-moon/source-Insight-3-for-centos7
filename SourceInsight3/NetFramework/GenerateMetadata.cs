public class GenerateMetadata : IComSoapMetadata
{

	// Constructors
	public GenerateMetadata() {}

	// Methods
	public static int SearchPath(string path, string fileName, string extension, int numBufferChars, string buffer, int[] filePart) {}
	public virtual string Generate(string strSrcTypeLib, string outPath) {}
	public virtual string GenerateSigned(string strSrcTypeLib, string outPath, bool InstallGacout , System.String& Error) {}
	public string GenerateMetaData(string strSrcTypeLib, string outPath, byte[] PublicKey, System.Reflection.StrongNameKeyPair KeyPair) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

