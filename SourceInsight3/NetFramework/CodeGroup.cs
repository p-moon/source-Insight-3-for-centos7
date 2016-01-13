public class CodeGroup
{

	// Methods
	public void AddChild(CodeGroup group) {}
	public void RemoveChild(CodeGroup group) {}
	public abstract virtual PolicyStatement Resolve(Evidence evidence) {}
	public abstract virtual CodeGroup ResolveMatchingCodeGroups(Evidence evidence) {}
	public abstract virtual CodeGroup Copy() {}
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
	public System.Collections.IList Children { get{} set{} }
	public IMembershipCondition MembershipCondition { get{} set{} }
	public PolicyStatement PolicyStatement { get{} set{} }
	public string Name { get{} set{} }
	public string Description { get{} set{} }
	public string PermissionSetName { get{} }
	public string AttributeString { get{} }
	public string MergeLogic { get{} }
}

