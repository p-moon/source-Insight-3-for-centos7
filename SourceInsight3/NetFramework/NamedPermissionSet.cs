public class NamedPermissionSet : PermissionSet, ISecurityEncodable, System.Collections.ICollection, System.Collections.IEnumerable, IStackWalk, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public NamedPermissionSet(string name) {}
	public NamedPermissionSet(string name, System.Security.Permissions.PermissionState state) {}
	public NamedPermissionSet(string name, PermissionSet permSet) {}
	public NamedPermissionSet(NamedPermissionSet permSet) {}

	// Methods
	public virtual PermissionSet Copy() {}
	public NamedPermissionSet Copy(string name) {}
	public virtual SecurityElement ToXml() {}
	public virtual void FromXml(SecurityElement et) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
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
	public virtual void Demand() {}
	public virtual void Assert() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual string ToString() {}
	public bool ContainsNonCodeAccessPermissions() {}
	public Type GetType() {}

	// Properties
	public string Name { get{} set{} }
	public string Description { get{} set{} }
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
	public bool IsReadOnly { get{} }
	public int Count { get{} }
}

