public class MimePart : ServiceDescriptionFormatExtension
{

	// Constructors
	public MimePart() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ServiceDescriptionFormatExtensionCollection Extensions { get{} }
	public object Parent { get{} }
	public bool Required { get{} set{} }
	public bool Handled { get{} set{} }
}

