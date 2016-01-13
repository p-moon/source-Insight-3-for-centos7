public class SoapOperationBinding : ServiceDescriptionFormatExtension
{

	// Constructors
	public SoapOperationBinding() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SoapAction { get{} set{} }
	public SoapBindingStyle Style { get{} set{} }
	public object Parent { get{} }
	public bool Required { get{} set{} }
	public bool Handled { get{} set{} }
}

