public class MimeTextBinding : ServiceDescriptionFormatExtension
{

	// Constructors
	public MimeTextBinding() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string Namespace;

	// Properties
	public MimeTextMatchCollection Matches { get{} }
	public object Parent { get{} }
	public bool Required { get{} set{} }
	public bool Handled { get{} set{} }
}

