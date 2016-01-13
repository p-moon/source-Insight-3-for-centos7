public interface ISymbolNamespace
{

	// Methods
	public abstract virtual ISymbolNamespace[] GetNamespaces() {}
	public abstract virtual ISymbolVariable[] GetVariables() {}

	// Properties
	public string Name { get{} }
}

