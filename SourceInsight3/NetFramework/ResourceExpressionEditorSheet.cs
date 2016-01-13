public class ResourceExpressionEditorSheet : ExpressionEditorSheet
{

	// Constructors
	public ResourceExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) {}

	// Methods
	public virtual string GetExpression() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ClassKey { get{} set{} }
	public bool IsValid { get{} }
	public string ResourceKey { get{} set{} }
	public System.IServiceProvider ServiceProvider { get{} }
}

