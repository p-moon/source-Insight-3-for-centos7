public class RegexCompilationInfo
{

	// Constructors
	public RegexCompilationInfo(string pattern, RegexOptions options, string name, string fullnamespace, bool ispublic) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Pattern { get{} set{} }
	public RegexOptions Options { get{} set{} }
	public string Name { get{} set{} }
	public string Namespace { get{} set{} }
	public bool IsPublic { get{} set{} }
}

