public class ResourceExpressionBuilder : ExpressionBuilder
{

	// Constructors
	public ResourceExpressionBuilder() {}

	// Methods
	public static ResourceExpressionFields ParseExpression(string expression) {}
	public virtual object ParseExpression(string expression, Type propertyType, ExpressionBuilderContext context) {}
	public virtual System.CodeDom.CodeExpression GetCodeExpression(System.Web.UI.BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context) {}
	public virtual object EvaluateExpression(object target, System.Web.UI.BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool SupportsEvaluate { get{} }
}

