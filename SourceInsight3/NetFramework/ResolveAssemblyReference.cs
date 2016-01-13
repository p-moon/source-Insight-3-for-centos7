public class ResolveAssemblyReference : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public ResolveAssemblyReference() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] AssemblyFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Assemblies { get{} set{} }
	public string[] CandidateAssemblyFiles { get{} set{} }
	public string[] TargetFrameworkDirectories { get{} set{} }
	public string[] InstalledAssemblyTables { get{} set{} }
	public string TargetProcessorArchitecture { get{} set{} }
	public string[] SearchPaths { get{} set{} }
	public string[] AllowedAssemblyExtensions { get{} set{} }
	public string[] AllowedRelatedFileExtensions { get{} set{} }
	public string AppConfigFile { get{} set{} }
	public bool AutoUnify { get{} set{} }
	public string StateFile { get{} set{} }
	public bool FindDependencies { get{} set{} }
	public bool FindSatellites { get{} set{} }
	public bool FindSerializationAssemblies { get{} set{} }
	public bool FindRelatedFiles { get{} set{} }
	public bool Silent { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ResolvedFiles { get{} }
	public Microsoft.Build.Framework.ITaskItem[] ResolvedDependencyFiles { get{} }
	public Microsoft.Build.Framework.ITaskItem[] RelatedFiles { get{} }
	public Microsoft.Build.Framework.ITaskItem[] SatelliteFiles { get{} }
	public Microsoft.Build.Framework.ITaskItem[] SerializationAssemblyFiles { get{} }
	public Microsoft.Build.Framework.ITaskItem[] ScatterFiles { get{} }
	public Microsoft.Build.Framework.ITaskItem[] CopyLocalFiles { get{} }
	public Microsoft.Build.Framework.ITaskItem[] SuggestedRedirects { get{} }
	public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}

