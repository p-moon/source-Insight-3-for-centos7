public class ApplicationDirectory : IBuiltInEvidence
{

	// Constructors
	public ApplicationDirectory(string name) {}

	// Methods
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public object Copy() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Directory { get{} }
}

