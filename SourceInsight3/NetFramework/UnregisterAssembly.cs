public class UnregisterAssembly : AppDomainIsolatedTaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public UnregisterAssembly() {}

	// Methods
	public virtual bool Execute() {}
	public virtual object InitializeLifetimeService() {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] Assemblies { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem AssemblyListFile { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}

