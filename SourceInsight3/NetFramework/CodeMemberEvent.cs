public class CodeMemberEvent : CodeTypeMember
{

	// Constructors
	public CodeMemberEvent() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference Type { get{} set{} }
	public CodeTypeReference PrivateImplementationType { get{} set{} }
	public CodeTypeReferenceCollection ImplementationTypes { get{} }
	public string Name { get{} set{} }
	public MemberAttributes Attributes { get{} set{} }
	public CodeAttributeDeclarationCollection CustomAttributes { get{} set{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeCommentStatementCollection Comments { get{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

