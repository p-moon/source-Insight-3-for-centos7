public class SymVariable : ISymbolVariable
{

	// Constructors
	public SymVariable(System.Diagnostics.SymbolStore.Private.ISymUnmanagedVariable* pVariable) {}

	// Methods
	public virtual byte[] GetSignature() {}
	public void {dtor}() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int EndOffset { get{} }
	public int StartOffset { get{} }
	public int AddressField3 { get{} }
	public int AddressField2 { get{} }
	public int AddressField1 { get{} }
	public SymAddressKind AddressKind { get{} }
	public object Attributes { get{} }
	public string Name { get{} }
}

