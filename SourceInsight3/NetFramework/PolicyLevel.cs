public class PolicyLevel
{

	// Methods
	public static PolicyLevel CreateAppDomainLevel() {}
	public CodeGroup ResolveMatchingCodeGroups(Evidence evidence) {}
	public void AddFullTrustAssembly(StrongName sn) {}
	public void AddFullTrustAssembly(StrongNameMembershipCondition snMC) {}
	public void RemoveFullTrustAssembly(StrongName sn) {}
	public void RemoveFullTrustAssembly(StrongNameMembershipCondition snMC) {}
	public void AddNamedPermissionSet(System.Security.NamedPermissionSet permSet) {}
	public System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.Security.NamedPermissionSet permSet) {}
	public System.Security.NamedPermissionSet RemoveNamedPermissionSet(string name) {}
	public System.Security.NamedPermissionSet ChangeNamedPermissionSet(string name, System.Security.PermissionSet pSet) {}
	public System.Security.NamedPermissionSet GetNamedPermissionSet(string name) {}
	public void Recover() {}
	public void Reset() {}
	public PolicyStatement Resolve(Evidence evidence) {}
	public System.Security.SecurityElement ToXml() {}
	public void FromXml(System.Security.SecurityElement e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Label { get{} }
	public System.Security.PolicyLevelType Type { get{} }
	public string StoreLocation { get{} }
	public CodeGroup RootCodeGroup { get{} set{} }
	public System.Collections.IList NamedPermissionSets { get{} }
	public System.Collections.IList FullTrustAssemblies { get{} }
}

