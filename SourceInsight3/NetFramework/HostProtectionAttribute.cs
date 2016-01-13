public class HostProtectionAttribute : CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public HostProtectionAttribute() {}
	public HostProtectionAttribute(SecurityAction action) {}

	// Methods
	public virtual System.Security.IPermission CreatePermission() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public HostProtectionResource Resources { get{} set{} }
	public bool Synchronization { get{} set{} }
	public bool SharedState { get{} set{} }
	public bool ExternalProcessMgmt { get{} set{} }
	public bool SelfAffectingProcessMgmt { get{} set{} }
	public bool ExternalThreading { get{} set{} }
	public bool SelfAffectingThreading { get{} set{} }
	public bool SecurityInfrastructure { get{} set{} }
	public bool UI { get{} set{} }
	public bool MayLeakOnAbort { get{} set{} }
	public SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}

