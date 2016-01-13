public class SymDocumentWriter : ISymbolDocumentWriter
{

	// Constructors
	public SymDocumentWriter(System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocumentWriter* pDocumentWriter) {}

	// Methods
	public System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocumentWriter* GetUnmanaged() {}
	public virtual void SetSource(byte[] source) {}
	public virtual void SetCheckSum(System.Guid algorithmId, byte[] source) {}
	public void {dtor}() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

