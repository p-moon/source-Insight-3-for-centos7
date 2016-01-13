public interface ICspAsymmetricAlgorithm
{

	// Methods
	public abstract virtual byte[] ExportCspBlob(bool includePrivateParameters) {}
	public abstract virtual void ImportCspBlob(byte[] rawData) {}

	// Properties
	public CspKeyContainerInfo CspKeyContainerInfo { get{} }
}

