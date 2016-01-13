public class SecurityPermissionAttribute : CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SecurityPermissionAttribute(SecurityAction action) {}

	// Methods
	public virtual System.Security.IPermission CreatePermission() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public SecurityPermissionFlag Flags { get{} set{} }
	public bool Assertion { get{} set{} }
	public bool UnmanagedCode { get{} set{} }
	public bool SkipVerification { get{} set{} }
	public bool Execution { get{} set{} }
	public bool ControlThread { get{} set{} }
	public bool ControlEvidence { get{} set{} }
	public bool ControlPolicy { get{} set{} }
	public bool SerializationFormatter { get{} set{} }
	public bool ControlDomainPolicy { get{} set{} }
	public bool ControlPrincipal { get{} set{} }
	public bool ControlAppDomain { get{} set{} }
	public bool RemotingConfiguration { get{} set{} }
	public bool Infrastructure { get{} set{} }
	public bool BindingRedirects { get{} set{} }
	public SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}

