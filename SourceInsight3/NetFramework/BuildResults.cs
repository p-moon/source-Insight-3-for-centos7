public class BuildResults : IBuildResults
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Succeeded { get{} }
	public string KeyFile { get{} }
	public string[] ComponentFiles { get{} }
	public BuildMessage[] Messages { get{} }
}

