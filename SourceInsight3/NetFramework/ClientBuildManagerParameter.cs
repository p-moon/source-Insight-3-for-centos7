public class ClientBuildManagerParameter
{

	// Constructors
	public ClientBuildManagerParameter() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PrecompilationFlags PrecompilationFlags { get{} set{} }
	public string StrongNameKeyFile { get{} set{} }
	public string StrongNameKeyContainer { get{} set{} }
}

