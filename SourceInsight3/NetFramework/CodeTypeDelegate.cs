public class CodeTypeDelegate : CodeTypeDeclaration
{

	// Constructors
	public CodeTypeDelegate() {}
	public CodeTypeDelegate(string name) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference ReturnType { get{} set{} }
	public CodeParameterDeclarationExpressionCollection Parameters { get{} }
	public System.Reflection.TypeAttributes TypeAttributes { get{} set{} }
	public CodeTypeReferenceCollection BaseTypes { get{} }
	public bool IsClass { get{} set{} }
	public bool IsStruct { get{} set{} }
	public bool IsEnum { get{} set{} }
	public bool IsInterface { get{} set{} }
	public bool IsPartial { get{} set{} }
	public CodeTypeMemberCollection Members { get{} }
	public CodeTypeParameterCollection TypeParameters { get{} }
	public string Name { get{} set{} }
	public MemberAttributes Attributes { get{} set{} }
	public CodeAttributeDeclarationCollection CustomAttributes { get{} set{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeCommentStatementCollection Comments { get{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }

	// Events
	public event System.EventHandler PopulateBaseTypes;
	public event System.EventHandler PopulateMembers;
}

