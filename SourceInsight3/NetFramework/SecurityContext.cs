public class SecurityContext
{

	// Methods
	public static System.Threading.AsyncFlowControl SuppressFlow() {}
	public static System.Threading.AsyncFlowControl SuppressFlowWindowsIdentity() {}
	public static void RestoreFlow() {}
	public static bool IsFlowSuppressed() {}
	public static bool IsWindowsIdentityFlowSuppressed() {}
	public static void Run(SecurityContext securityContext, System.Threading.ContextCallback callback, object state) {}
	public SecurityContext CreateCopy() {}
	public static SecurityContext Capture() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

