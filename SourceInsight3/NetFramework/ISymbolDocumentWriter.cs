public interface ISymbolDocumentWriter
{

	// Methods
	public abstract virtual void SetSource(byte[] source) {}
	public abstract virtual void SetCheckSum(System.Guid algorithmId, byte[] checkSum) {}
}

