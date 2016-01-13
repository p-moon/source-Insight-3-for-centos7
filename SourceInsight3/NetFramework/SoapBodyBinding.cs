public class SoapBodyBinding : ServiceDescriptionFormatExtension
{

	// Constructors
	public SoapBodyBinding() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SoapBindingUse Use { get{} set{} }
	public string Namespace { get{} set{} }
	public string Encoding { get{} set{} }
	public string PartsString { get{} set{} }
	public string[] Parts { get{} set{} }
	public object Parent { get{} }
	public bool Required { get{} set{} }
	public bool Handled { get{} set{} }
}

