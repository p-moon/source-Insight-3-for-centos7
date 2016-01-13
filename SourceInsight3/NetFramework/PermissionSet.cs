public class PermissionSet : ISecurityEncodable, System.Collections.ICollection, System.Collections.IEnumerable, IStackWalk, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public PermissionSet(System.Security.Permissions.PermissionState state) {}
	public PermissionSet(PermissionSet permSet) {}

	// Methods
	public bool IsEmpty() {}
	public bool IsSubsetOf(PermissionSet target) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public IPermission GetPermission(Type permClass) {}
	public IPermission SetPermission(IPermission perm) {}
	public IPermission AddPermission(IPermission perm) {}
	public IPermission RemovePermission(Type permClass) {}
	public bool IsUnrestricted() {}
	public PermissionSet Intersect(PermissionSet other) {}
	public PermissionSet Union(PermissionSet other) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual void Demand() {}
	public virtual void Assert() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual PermissionSet Copy() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual string ToString() {}
	public virtual void FromXml(SecurityElement et) {}
	public virtual SecurityElement ToXml() {}
	public static byte[] ConvertPermissionSet(string inFormat, byte[] inData, string outFormat) {}
	public bool ContainsNonCodeAccessPermissions() {}
	public static void RevertAssert() {}
	public Type GetType() {}

	// Properties
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
	public bool IsReadOnly { get{} }
	public int Count { get{} }
}

