public class CompilationSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public CompilationSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string TempDirectory { get{} set{} }
	public bool Debug { get{} set{} }
	public bool Strict { get{} set{} }
	public bool Explicit { get{} set{} }
	public bool Batch { get{} set{} }
	public bool UrlLinePragmas { get{} set{} }
	public System.TimeSpan BatchTimeout { get{} set{} }
	public int MaxBatchSize { get{} set{} }
	public int MaxBatchGeneratedFileSize { get{} set{} }
	public int NumRecompilesBeforeAppRestart { get{} set{} }
	public string DefaultLanguage { get{} set{} }
	public CompilerCollection Compilers { get{} }
	public AssemblyCollection Assemblies { get{} }
	public BuildProviderCollection BuildProviders { get{} }
	public ExpressionBuilderCollection ExpressionBuilders { get{} }
	public string AssemblyPostProcessorType { get{} set{} }
	public CodeSubDirectoriesCollection CodeSubDirectories { get{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

