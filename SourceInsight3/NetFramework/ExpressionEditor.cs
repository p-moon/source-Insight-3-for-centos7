public class ExpressionEditor
{

	// Methods
	public abstract virtual object EvaluateExpression(string expression, object parseTimeData, Type propertyType, System.IServiceProvider serviceProvider) {}
	public static ExpressionEditor GetExpressionEditor(Type expressionBuilderType, System.IServiceProvider serviceProvider) {}
	public static ExpressionEditor GetExpressionEditor(string expressionPrefix, System.IServiceProvider serviceProvider) {}
	public virtual ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ExpressionPrefix { get{} }
}

