public class EventLogInstaller : System.Configuration.Install.ComponentInstaller, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public EventLogInstaller() {}

	// Methods
	public virtual void CopyFromComponent(System.ComponentModel.IComponent component) {}
	public virtual void Install(System.Collections.IDictionary stateSaver) {}
	public virtual bool IsEquivalentInstaller(System.Configuration.Install.ComponentInstaller otherInstaller) {}
	public virtual void Rollback(System.Collections.IDictionary savedState) {}
	public virtual void Uninstall(System.Collections.IDictionary savedState) {}
	public virtual void Commit(System.Collections.IDictionary savedState) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CategoryResourceFile { get{} set{} }
	public int CategoryCount { get{} set{} }
	public string Log { get{} set{} }
	public string MessageResourceFile { get{} set{} }
	public string ParameterResourceFile { get{} set{} }
	public string Source { get{} set{} }
	public System.Configuration.Install.UninstallAction UninstallAction { get{} set{} }
	public System.Configuration.Install.InstallContext Context { get{} set{} }
	public string HelpText { get{} }
	public System.Configuration.Install.InstallerCollection Installers { get{} }
	public System.Configuration.Install.Installer Parent { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Configuration.Install.InstallEventHandler Committed;
	public event System.Configuration.Install.InstallEventHandler AfterInstall;
	public event System.Configuration.Install.InstallEventHandler AfterRollback;
	public event System.Configuration.Install.InstallEventHandler AfterUninstall;
	public event System.Configuration.Install.InstallEventHandler Committing;
	public event System.Configuration.Install.InstallEventHandler BeforeInstall;
	public event System.Configuration.Install.InstallEventHandler BeforeRollback;
	public event System.Configuration.Install.InstallEventHandler BeforeUninstall;
	public event System.EventHandler Disposed;
}

