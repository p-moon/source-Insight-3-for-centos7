public class CodeDirectionExpression : CodeExpression
{

	// Constructors
	public CodeDirectionExpression() {}
	public CodeDirectionExpression(FieldDirection direction, CodeExpression expression) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression Expression { get{} set{} }
	public FieldDirection Direction { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

