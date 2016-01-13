public class Soap12OperationBinding : SoapOperationBinding
{

	// Constructors
	public Soap12OperationBinding() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool SoapActionRequired { get{} set{} }
	public string SoapAction { get{} set{} }
	public SoapBindingStyle Style { get{} set{} }
	public object Parent { get{} }
	public bool Required { get{} set{} }
	public bool Handled { get{} set{} }
}

