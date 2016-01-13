public class ResolveComReference : AppDomainIsolatedTaskExtension, Microsoft.Build.Framework.ITask, IComReferenceResolver
{

	// Constructors
	public ResolveComReference() {}

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
	public Microsoft.Build.Framework.ITaskItem[] TypeLibNames { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get{} set{} }
	public string WrapperOutputDirectory { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ResolvedAssemblyReferences { get{} set{} }
	public string KeyContainer { get{} set{} }
	public string KeyFile { get{} set{} }
	public bool DelaySign { get{} set{} }
	public bool NoClassMembers { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ResolvedFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ResolvedModules { get{} set{} }
	public string StateFile { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}

