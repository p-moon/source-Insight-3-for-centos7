public interface ISymbolScope
{

	// Methods
	public abstract virtual ISymbolScope[] GetChildren() {}
	public abstract virtual ISymbolVariable[] GetLocals() {}
	public abstract virtual ISymbolNamespace[] GetNamespaces() {}

	// Properties
	public ISymbolMethod Method { get{} }
	public ISymbolScope Parent { get{} }
	public int StartOffset { get{} }
	public int EndOffset { get{} }
}

