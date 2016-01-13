public class Engine
{

	// Constructors
	public Engine() {}
	public Engine(string binPath) {}

	// Methods
	public void RegisterLogger(Microsoft.Build.Framework.ILogger logger) {}
	public void UnregisterAllLoggers() {}
	public Project CreateNewProject() {}
	public Project GetLoadedProject(string projectFullFileName) {}
	public void UnloadProject(Project project) {}
	public void UnloadAllProjects() {}
	public bool BuildProject(Project project) {}
	public bool BuildProject(Project project, string targetName) {}
	public bool BuildProject(Project project, string[] targetNames) {}
	public bool BuildProject(Project project, string[] targetNames, System.Collections.IDictionary targetOutputs) {}
	public bool BuildProject(Project project, string[] targetNames, System.Collections.IDictionary targetOutputs, BuildSettings buildFlags) {}
	public bool BuildProjectFile(string projectFile) {}
	public bool BuildProjectFile(string projectFile, string targetName) {}
	public bool BuildProjectFile(string projectFile, string[] targetNames) {}
	public bool BuildProjectFile(string projectFile, string[] targetNames, BuildPropertyGroup globalProperties) {}
	public bool BuildProjectFile(string projectFile, string[] targetNames, BuildPropertyGroup globalProperties, System.Collections.IDictionary targetOutputs) {}
	public bool BuildProjectFile(string projectFile, string[] targetNames, BuildPropertyGroup globalProperties, System.Collections.IDictionary targetOutputs, BuildSettings buildFlags) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string BinPath { get{} set{} }
	public Engine GlobalEngine { get{} }
	public System.Version Version { get{} }
	public BuildPropertyGroup GlobalProperties { get{} set{} }
	public bool BuildEnabled { get{} set{} }
	public bool OnlyLogCriticalEvents { get{} set{} }
}

