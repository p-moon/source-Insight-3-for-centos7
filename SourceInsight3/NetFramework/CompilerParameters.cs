public class CompilerParameters
{

	// Constructors
	public CompilerParameters() {}
	public CompilerParameters(string[] assemblyNames) {}
	public CompilerParameters(string[] assemblyNames, string outputName) {}
	public CompilerParameters(string[] assemblyNames, string outputName, bool includeDebugInformation) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool GenerateExecutable { get{} set{} }
	public bool GenerateInMemory { get{} set{} }
	public System.Collections.Specialized.StringCollection ReferencedAssemblies { get{} }
	public string MainClass { get{} set{} }
	public string OutputAssembly { get{} set{} }
	public TempFileCollection TempFiles { get{} set{} }
	public bool IncludeDebugInformation { get{} set{} }
	public bool TreatWarningsAsErrors { get{} set{} }
	public int WarningLevel { get{} set{} }
	public string CompilerOptions { get{} set{} }
	public string Win32Resource { get{} set{} }
	public System.Collections.Specialized.StringCollection EmbeddedResources { get{} }
	public System.Collections.Specialized.StringCollection LinkedResources { get{} }
	public System.IntPtr UserToken { get{} set{} }
	public System.Security.Policy.Evidence Evidence { get{} set{} }
}

