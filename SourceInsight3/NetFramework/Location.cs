public class Location : _Location
{

	// Constructors
	public Location() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public uint BeginningLine { get{} set{} }
	public uint BeginningColumn { get{} set{} }
	public uint EndLine { get{} set{} }
	public uint EndColumn { get{} set{} }
}

