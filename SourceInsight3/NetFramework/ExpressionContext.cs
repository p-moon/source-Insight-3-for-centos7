public class ExpressionContext
{

	// Constructors
	public ExpressionContext(System.CodeDom.CodeExpression expression, Type expressionType, object owner, object presetValue) {}
	public ExpressionContext(System.CodeDom.CodeExpression expression, Type expressionType, object owner) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.CodeDom.CodeExpression Expression { get{} }
	public Type ExpressionType { get{} }
	public object Owner { get{} }
	public object PresetValue { get{} }
}

