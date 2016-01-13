public class ParseErrorEnumerator : System.Collections.IEnumerator
{

	// Constructors
	public ParseErrorEnumerator(ManifestParseErrors manifestParseErrors) {}

	// Methods
	public virtual void Reset() {}
	public virtual bool MoveNext() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ManifestParseError Current { get{} }
}

