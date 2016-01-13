public interface ISymbolVariable
{

	// Methods
	public abstract virtual byte[] GetSignature() {}

	// Properties
	public string Name { get{} }
	public object Attributes { get{} }
	public SymAddressKind AddressKind { get{} }
	public int AddressField1 { get{} }
	public int AddressField2 { get{} }
	public int AddressField3 { get{} }
	public int StartOffset { get{} }
	public int EndOffset { get{} }
}

