public class MimeXmlBinding : ServiceDescriptionFormatExtension
{

	// Constructors
	public MimeXmlBinding() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Part { get{} set{} }
	public object Parent { get{} }
	public bool Required { get{} set{} }
	public bool Handled { get{} set{} }
}

