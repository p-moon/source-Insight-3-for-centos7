public class SecurityException : System.SystemException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public SecurityException() {}
	public SecurityException(string message) {}
	public SecurityException(string message, Type type) {}
	public SecurityException(string message, Type type, string state) {}
	public SecurityException(string message, System.Exception inner) {}
	public SecurityException(string message, System.Reflection.AssemblyName assemblyName, PermissionSet grant, PermissionSet refused, System.Reflection.MethodInfo method, System.Security.Permissions.SecurityAction action, object demanded, IPermission permThatFailed, System.Security.Policy.Evidence evidence) {}
	public SecurityException(string message, object deny, object permitOnly, System.Reflection.MethodInfo method, object demanded, IPermission permThatFailed) {}

	// Methods
	public virtual string ToString() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Permissions.SecurityAction Action { get{} set{} }
	public Type PermissionType { get{} set{} }
	public IPermission FirstPermissionThatFailed { get{} set{} }
	public string PermissionState { get{} set{} }
	public object Demanded { get{} set{} }
	public string GrantedSet { get{} set{} }
	public string RefusedSet { get{} set{} }
	public object DenySetInstance { get{} set{} }
	public object PermitOnlySetInstance { get{} set{} }
	public System.Reflection.AssemblyName FailedAssemblyInfo { get{} set{} }
	public System.Reflection.MethodInfo Method { get{} set{} }
	public SecurityZone Zone { get{} set{} }
	public string Url { get{} set{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

