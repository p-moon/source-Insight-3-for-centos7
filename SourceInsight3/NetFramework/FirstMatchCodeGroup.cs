public class FirstMatchCodeGroup : CodeGroup
{

	// Constructors
	public FirstMatchCodeGroup(IMembershipCondition membershipCondition, PolicyStatement policy) {}

	// Methods
	public virtual PolicyStatement Resolve(Evidence evidence) {}
	public virtual CodeGroup ResolveMatchingCodeGroups(Evidence evidence) {}
	public virtual CodeGroup Copy() {}
	public void AddChild(CodeGroup group) {}
	public void RemoveChild(CodeGroup group) {}
	public System.Security.SecurityElement ToXml() {}
	public void FromXml(System.Security.SecurityElement e) {}
	public System.Security.SecurityElement ToXml(PolicyLevel level) {}
	public void FromXml(System.Security.SecurityElement e, PolicyLevel level) {}
	public virtual bool Equals(object o) {}
	public bool Equals(CodeGroup cg, bool compareChildren) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string MergeLogic { get{} }
	public System.Collections.IList Children { get{} set{} }
	public IMembershipCondition MembershipCondition { get{} set{} }
	public PolicyStatement PolicyStatement { get{} set{} }
	public string Name { get{} set{} }
	public string Description { get{} set{} }
	public string PermissionSetName { get{} }
	public string AttributeString { get{} }
}

