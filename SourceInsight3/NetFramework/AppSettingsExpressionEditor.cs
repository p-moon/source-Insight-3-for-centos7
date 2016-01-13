public class AppSettingsExpressionEditor : ExpressionEditor
{

	// Constructors
	public AppSettingsExpressionEditor() {}

	// Methods
	public virtual ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) {}
	public virtual object EvaluateExpression(string expression, object parseTimeData, Type propertyType, System.IServiceProvider serviceProvider) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ExpressionPrefix { get{} }
}

