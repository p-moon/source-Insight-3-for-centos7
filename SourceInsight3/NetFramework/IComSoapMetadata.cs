public interface IComSoapMetadata
{

	// Methods
	public abstract virtual string Generate(string SrcTypeLibFileName, string OutPath) {}
	public abstract virtual string GenerateSigned(string SrcTypeLibFileName, string OutPath, bool InstallGacout , System.String& Error) {}
}

