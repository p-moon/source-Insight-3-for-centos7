public interface ISymbolDocument
{

	// Methods
	public abstract virtual byte[] GetCheckSum() {}
	public abstract virtual int FindClosestLine(int line) {}
	public abstract virtual byte[] GetSourceRange(int startLine, int startColumn, int endLine, int endColumn) {}

	// Properties
	public string URL { get{} }
	public System.Guid DocumentType { get{} }
	public System.Guid Language { get{} }
	public System.Guid LanguageVendor { get{} }
	public System.Guid CheckSumAlgorithmId { get{} }
	public bool HasEmbeddedSource { get{} }
	public int SourceLength { get{} }
}

