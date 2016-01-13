public class SymReader : ISymbolReader
{

	// Constructors
	public SymReader(System.Diagnostics.SymbolStore.Private.ISymUnmanagedReader* pReader) {}

	// Methods
	public virtual ISymbolDocument GetDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) {}
	public virtual ISymbolDocument[] GetDocuments() {}
	public virtual ISymbolMethod GetMethod(SymbolToken method, int version) {}
	public virtual ISymbolMethod GetMethod(SymbolToken method) {}
	public virtual ISymbolVariable[] GetVariables(SymbolToken parent) {}
	public virtual ISymbolVariable[] GetGlobalVariables() {}
	public virtual ISymbolMethod GetMethodFromDocumentPosition(ISymbolDocument document, int line, int column) {}
	public virtual byte[] GetSymAttribute(SymbolToken parent, string name) {}
	public virtual ISymbolNamespace[] GetNamespaces() {}
	public void UpdateSymbolStore(string fileName, System.IntPtr stream) {}
	public void ReplaceSymbolStore(string fileName, System.IntPtr stream) {}
	public void {dtor}() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SymbolToken UserEntryPoint { get{} }
}

