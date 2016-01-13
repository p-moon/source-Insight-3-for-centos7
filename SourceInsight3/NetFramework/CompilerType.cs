public class CompilerType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object o) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type CodeDomProviderType { get{} }
	public System.CodeDom.Compiler.CompilerParameters CompilerParameters { get{} }
}

