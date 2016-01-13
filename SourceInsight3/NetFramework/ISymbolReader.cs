public interface ISymbolReader
{

	// Methods
	public abstract virtual ISymbolDocument GetDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) {}
	public abstract virtual ISymbolDocument[] GetDocuments() {}
	public abstract virtual ISymbolMethod GetMethod(SymbolToken method) {}
	public abstract virtual ISymbolMethod GetMethod(SymbolToken method, int version) {}
	public abstract virtual ISymbolVariable[] GetVariables(SymbolToken parent) {}
	public abstract virtual ISymbolVariable[] GetGlobalVariables() {}
	public abstract virtual ISymbolMethod GetMethodFromDocumentPosition(ISymbolDocument document, int line, int column) {}
	public abstract virtual byte[] GetSymAttribute(SymbolToken parent, string name) {}
	public abstract virtual ISymbolNamespace[] GetNamespaces() {}

	// Properties
	public SymbolToken UserEntryPoint { get{} }
}

