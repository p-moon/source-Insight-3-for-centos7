public class MimeMultipartRelatedBinding : ServiceDescriptionFormatExtension
{

	// Constructors
	public MimeMultipartRelatedBinding() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MimePartCollection Parts { get{} }
	public object Parent { get{} }
	public bool Required { get{} set{} }
	public bool Handled { get{} set{} }
}

