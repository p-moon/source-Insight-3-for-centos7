public class SecurityManager
{

	// Methods
	public static bool IsGranted(IPermission perm) {}
	public static void GetZoneAndOrigin(out System.Collections.ArrayList& zoneout , System.Collections.ArrayList& origin) {}
	public static System.Security.Policy.PolicyLevel LoadPolicyLevelFromFile(string path, PolicyLevelType type) {}
	public static System.Security.Policy.PolicyLevel LoadPolicyLevelFromString(string str, PolicyLevelType type) {}
	public static void SavePolicyLevel(System.Security.Policy.PolicyLevel level) {}
	public static PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence, PermissionSet reqdPset, PermissionSet optPset, PermissionSet denyPsetout , PermissionSet& denied) {}
	public static PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence) {}
	public static PermissionSet ResolvePolicy(System.Security.Policy.Evidence[] evidences) {}
	public static PermissionSet ResolveSystemPolicy(System.Security.Policy.Evidence evidence) {}
	public static System.Collections.IEnumerator ResolvePolicyGroups(System.Security.Policy.Evidence evidence) {}
	public static System.Collections.IEnumerator PolicyHierarchy() {}
	public static void SavePolicy() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CheckExecutionRights { get{} set{} }
	public bool SecurityEnabled { get{} set{} }
}

