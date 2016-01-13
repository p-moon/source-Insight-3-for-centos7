public class RegisterAssembly : AppDomainIsolatedTaskExtension, Microsoft.Build.Framework.ITask, System.Runtime.InteropServices.ITypeLibExporterNotifySink
{

	// Constructors
	public RegisterAssembly() {}

	// Methods
	public virtual bool Execute() {}
	public virtual void ReportEvent(System.Runtime.InteropServices.ExporterEventKind kind, int code, string msg) {}
	public virtual object ResolveRef(System.Reflection.Assembly assemblyToResolve) {}
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
	public bool CreateCodeBase { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem AssemblyListFile { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}

