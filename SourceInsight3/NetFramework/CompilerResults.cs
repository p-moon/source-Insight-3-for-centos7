public class CompilerResults
{

	// Constructors
	public CompilerResults(TempFileCollection tempFiles) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TempFileCollection TempFiles { get{} set{} }
	public System.Security.Policy.Evidence Evidence { get{} set{} }
	public System.Reflection.Assembly CompiledAssembly { get{} set{} }
	public CompilerErrorCollection Errors { get{} }
	public System.Collections.Specialized.StringCollection Output { get{} }
	public string PathToAssembly { get{} set{} }
	public int NativeCompilerReturnValue { get{} set{} }
}

