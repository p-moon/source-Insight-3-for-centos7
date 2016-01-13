public class SymScope : ISymbolScope
{

	// Constructors
	public SymScope(System.Diagnostics.SymbolStore.Private.ISymUnmanagedScope* pScope) {}

	// Methods
	public virtual ISymbolScope[] GetChildren() {}
	public virtual ISymbolVariable[] GetLocals() {}
	public virtual ISymbolNamespace[] GetNamespaces() {}
	public void {dtor}() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int EndOffset { get{} }
	public int StartOffset { get{} }
	public ISymbolScope Parent { get{} }
	public ISymbolMethod Method { get{} }
}

