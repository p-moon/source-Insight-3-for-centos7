public class SymDocument : ISymbolDocument
{

	// Constructors
	public SymDocument(System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocument* pDocument) {}

	// Methods
	public System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocument* GetUnmanaged() {}
	public virtual byte[] GetCheckSum() {}
	public virtual int FindClosestLine(int line) {}
	public virtual byte[] GetSourceRange(int startLine, int startColumn, int endLine, int endColumn) {}
	public void {dtor}() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int SourceLength { get{} }
	public bool HasEmbeddedSource { get{} }
	public System.Guid CheckSumAlgorithmId { get{} }
	public System.Guid LanguageVendor { get{} }
	public System.Guid Language { get{} }
	public System.Guid DocumentType { get{} }
	public string URL { get{} }
}

