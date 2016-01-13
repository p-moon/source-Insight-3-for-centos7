public class SecurityUtilities
{

	// Methods
	public static System.Security.PermissionSet ComputeZonePermissionSet(string targetZone, System.Security.PermissionSet includedPermissionSet, string[] excludedPermissions) {}
	public static System.Security.PermissionSet IdentityListToPermissionSet(string[] ids) {}
	public static string[] PermissionSetToIdentityList(System.Security.PermissionSet permissionSet) {}
	public static System.Security.PermissionSet XmlToPermissionSet(System.Xml.XmlElement element) {}
	public static void SignFile(string certThumbprint, System.Uri timestampUrl, string path) {}
	public static void SignFile(string certPath, System.Security.SecureString certPassword, System.Uri timestampUrl, string path) {}
	public static void SignFile(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Uri timestampUrl, string path) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

