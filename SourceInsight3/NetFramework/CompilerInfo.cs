public class CompilerInfo
{

	// Methods
	public string[] GetLanguages() {}
	public string[] GetExtensions() {}
	public CodeDomProvider CreateProvider() {}
	public CompilerParameters CreateDefaultCompilerParameters() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object o) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type CodeDomProviderType { get{} }
	public bool IsCodeDomProviderTypeValid { get{} }
}

