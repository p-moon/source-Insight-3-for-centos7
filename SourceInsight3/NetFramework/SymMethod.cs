public class SymMethod : ISymbolMethod
{

	// Constructors
	public SymMethod(System.Diagnostics.SymbolStore.Private.ISymUnmanagedMethod* pMethod) {}

	// Methods
	public virtual void GetSequencePoints(int[] offsets, ISymbolDocument[] documents, int[] lines, int[] columns, int[] endLines, int[] endColumns) {}
	public ISymbolScope RootScopeInternal() {}
	public virtual ISymbolScope GetScope(int offset) {}
	public virtual int GetOffset(ISymbolDocument document, int line, int column) {}
	public virtual int[] GetRanges(ISymbolDocument document, int line, int column) {}
	public virtual ISymbolVariable[] GetParameters() {}
	public virtual ISymbolNamespace GetNamespace() {}
	public virtual bool GetSourceStartEnd(ISymbolDocument[] docs, int[] lines, int[] columns) {}
	public void {dtor}() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ISymbolScope RootScope { get{} }
	public int SequencePointCount { get{} }
	public SymbolToken Token { get{} }
}

