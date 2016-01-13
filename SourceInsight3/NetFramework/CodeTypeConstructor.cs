public class CodeTypeConstructor : CodeMemberMethod
{

	// Constructors
	public CodeTypeConstructor() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference ReturnType { get{} set{} }
	public CodeStatementCollection Statements { get{} }
	public CodeParameterDeclarationExpressionCollection Parameters { get{} }
	public CodeTypeReference PrivateImplementationType { get{} set{} }
	public CodeTypeReferenceCollection ImplementationTypes { get{} }
	public CodeAttributeDeclarationCollection ReturnTypeCustomAttributes { get{} }
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
	public event System.EventHandler PopulateParameters;
	public event System.EventHandler PopulateStatements;
	public event System.EventHandler PopulateImplementationTypes;
}

