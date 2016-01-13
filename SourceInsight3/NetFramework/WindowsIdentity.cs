public class WindowsIdentity : IIdentity, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback, System.IDisposable
{

	// Constructors
	public WindowsIdentity(System.IntPtr userToken) {}
	public WindowsIdentity(System.IntPtr userToken, string type) {}
	public WindowsIdentity(System.IntPtr userToken, string type, WindowsAccountType acctType) {}
	public WindowsIdentity(System.IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) {}
	public WindowsIdentity(string sUserPrincipalName) {}
	public WindowsIdentity(string sUserPrincipalName, string type) {}
	public WindowsIdentity(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}

	// Methods
	public static WindowsIdentity GetCurrent() {}
	public static WindowsImpersonationContext Impersonate(System.IntPtr userToken) {}
	public static WindowsIdentity GetCurrent(bool ifImpersonating) {}
	public static WindowsIdentity GetCurrent(TokenAccessLevels desiredAccess) {}
	public static WindowsIdentity GetAnonymous() {}
	public virtual WindowsImpersonationContext Impersonate() {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AuthenticationType { get{} }
	public TokenImpersonationLevel ImpersonationLevel { get{} }
	public bool IsAuthenticated { get{} }
	public bool IsGuest { get{} }
	public bool IsSystem { get{} }
	public bool IsAnonymous { get{} }
	public string Name { get{} }
	public SecurityIdentifier Owner { get{} }
	public SecurityIdentifier User { get{} }
	public IdentityReferenceCollection Groups { get{} }
	public System.IntPtr Token { get{} }
}

