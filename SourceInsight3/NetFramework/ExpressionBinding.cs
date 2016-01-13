public class ExpressionBinding
{

	// Constructors
	public ExpressionBinding(string propertyName, Type propertyType, string expressionPrefix, string expression) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Expression { get{} set{} }
	public string ExpressionPrefix { get{} set{} }
	public bool Generated { get{} }
	public object ParsedExpressionData { get{} }
	public string PropertyName { get{} }
	public Type PropertyType { get{} }
}

