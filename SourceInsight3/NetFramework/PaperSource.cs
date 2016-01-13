public class PaperSource
{

	// Constructors
	public PaperSource() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PaperSourceKind Kind { get{} }
	public int RawKind { get{} set{} }
	public string SourceName { get{} set{} }
}

