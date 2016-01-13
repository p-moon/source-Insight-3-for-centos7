public interface ISymbolWriter
{

	// Methods
	public abstract virtual void Initialize(System.IntPtr emitter, string filename, bool fFullBuild) {}
	public abstract virtual ISymbolDocumentWriter DefineDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) {}
	public abstract virtual void SetUserEntryPoint(SymbolToken entryMethod) {}
	public abstract virtual void OpenMethod(SymbolToken method) {}
	public abstract virtual void CloseMethod() {}
	public abstract virtual void DefineSequencePoints(ISymbolDocumentWriter document, int[] offsets, int[] lines, int[] columns, int[] endLines, int[] endColumns) {}
	public abstract virtual int OpenScope(int startOffset) {}
	public abstract virtual void CloseScope(int endOffset) {}
	public abstract virtual void SetScopeRange(int scopeID, int startOffset, int endOffset) {}
	public abstract virtual void DefineLocalVariable(string name, System.Reflection.FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3, int startOffset, int endOffset) {}
	public abstract virtual void DefineParameter(string name, System.Reflection.ParameterAttributes attributes, int sequence, SymAddressKind addrKind, int addr1, int addr2, int addr3) {}
	public abstract virtual void DefineField(SymbolToken parent, string name, System.Reflection.FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3) {}
	public abstract virtual void DefineGlobalVariable(string name, System.Reflection.FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3) {}
	public abstract virtual void Close() {}
	public abstract virtual void SetSymAttribute(SymbolToken parent, string name, byte[] data) {}
	public abstract virtual void OpenNamespace(string name) {}
	public abstract virtual void CloseNamespace() {}
	public abstract virtual void UsingNamespace(string fullName) {}
	public abstract virtual void SetMethodSourceRange(ISymbolDocumentWriter startDoc, int startLine, int startColumn, ISymbolDocumentWriter endDoc, int endLine, int endColumn) {}
	public abstract virtual void SetUnderlyingWriter(System.IntPtr underlyingWriter) {}
}

