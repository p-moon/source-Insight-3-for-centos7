public class ExpressionEditorSheet
{

	// Methods
	public abstract virtual string GetExpression() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsValid { get{} }
	public System.IServiceProvider ServiceProvider { get{} }
}

