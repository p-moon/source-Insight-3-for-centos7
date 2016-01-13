public class NetCodeGroup : CodeGroup, IUnionSemanticCodeGroup
{

	// Constructors
	public NetCodeGroup(IMembershipCondition membershipCondition) {}

	// Methods
	public void ResetConnectAccess() {}
	public void AddConnectAccess(string originScheme, CodeConnectAccess connectAccess) {}
	public System.Collections.DictionaryEntry[] GetConnectAccessRules() {}
	public virtual PolicyStatement Resolve(Evidence evidence) {}
	public virtual CodeGroup ResolveMatchingCodeGroups(Evidence evidence) {}
	public virtual CodeGroup Copy() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public void AddChild(CodeGroup group) {}
	public void RemoveChild(CodeGroup group) {}
	public System.Security.SecurityElement ToXml() {}
	public void FromXml(System.Security.SecurityElement e) {}
	public System.Security.SecurityElement ToXml(PolicyLevel level) {}
	public void FromXml(System.Security.SecurityElement e, PolicyLevel level) {}
	public bool Equals(CodeGroup cg, bool compareChildren) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public string AnyOtherOriginScheme;
	public string AbsentOriginScheme;

	// Properties
	public string MergeLogic { get{} }
	public string PermissionSetName { get{} }
	public string AttributeString { get{} }
	public System.Collections.IList Children { get{} set{} }
	public IMembershipCondition MembershipCondition { get{} set{} }
	public PolicyStatement PolicyStatement { get{} set{} }
	public string Name { get{} set{} }
	public string Description { get{} set{} }
}

