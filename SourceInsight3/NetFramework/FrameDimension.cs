public class FrameDimension
{

	// Constructors
	public FrameDimension(System.Guid guid) {}

	// Methods
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.Guid Guid { get{} }
	public FrameDimension Time { get{} }
	public FrameDimension Resolution { get{} }
	public FrameDimension Page { get{} }
}

