public class SymWriter : ISymbolWriter
{

	// Constructors
	public SymWriter(bool noUnderlyingWriter) {}
	public SymWriter() {}

	// Methods
	public void InitWriter(bool noUnderlyingWriter) {}
	public System.Diagnostics.SymbolStore.Private.ISymUnmanagedWriter* GetWriter() {}
	public virtual ISymbolDocumentWriter DefineDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) {}
	public virtual void SetUserEntryPoint(SymbolToken entryMethod) {}
	public virtual void OpenMethod(SymbolToken method) {}
	public virtual void CloseMethod() {}
	public virtual int OpenScope(int startOffset) {}
	public virtual void CloseScope(int endOffset) {}
	public virtual void SetScopeRange(int scopeID, int startOffset, int endOffset) {}
	public virtual void DefineLocalVariable(string name, System.Reflection.FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3, int startOffset, int endOffset) {}
	public virtual void DefineParameter(string name, System.Reflection.ParameterAttributes attributes, int sequence, SymAddressKind addrKind, int addr1, int addr2, int addr3) {}
	public virtual void DefineField(SymbolToken parent, string name, System.Reflection.FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3) {}
	public virtual void DefineGlobalVariable(string name, System.Reflection.FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3) {}
	public virtual void Close() {}
	public virtual void SetSymAttribute(SymbolToken parent, string name, byte[] data) {}
	public virtual void OpenNamespace(string name) {}
	public virtual void CloseNamespace() {}
	public virtual void UsingNamespace(string fullName) {}
	public virtual void SetMethodSourceRange(ISymbolDocumentWriter startDoc, int startLine, int startColumn, ISymbolDocumentWriter endDoc, int endLine, int endColumn) {}
	public virtual void Initialize(System.IntPtr emitter, string filename, bool fFullBuild) {}
	public virtual void DefineSequencePoints(ISymbolDocumentWriter document, int[] offsets, int[] lines, int[] columns, int[] endLines, int[] endColumns) {}
	public virtual void SetUnderlyingWriter(System.IntPtr underlyingWriter) {}
	public void {dtor}() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

