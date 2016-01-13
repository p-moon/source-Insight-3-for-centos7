public class CodeRemoveEventStatement : CodeStatement
{

	// Constructors
	public CodeRemoveEventStatement() {}
	public CodeRemoveEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener) {}
	public CodeRemoveEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeEventReferenceExpression Event { get{} set{} }
	public CodeExpression Listener { get{} set{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

