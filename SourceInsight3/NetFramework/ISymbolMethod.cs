public interface ISymbolMethod
{

	// Methods
	public abstract virtual void GetSequencePoints(int[] offsets, ISymbolDocument[] documents, int[] lines, int[] columns, int[] endLines, int[] endColumns) {}
	public abstract virtual ISymbolScope GetScope(int offset) {}
	public abstract virtual int GetOffset(ISymbolDocument document, int line, int column) {}
	public abstract virtual int[] GetRanges(ISymbolDocument document, int line, int column) {}
	public abstract virtual ISymbolVariable[] GetParameters() {}
	public abstract virtual ISymbolNamespace GetNamespace() {}
	public abstract virtual bool GetSourceStartEnd(ISymbolDocument[] docs, int[] lines, int[] columns) {}

	// Properties
	public SymbolToken Token { get{} }
	public int SequencePointCount { get{} }
	public ISymbolScope RootScope { get{} }
}

