public interface IContextProperty
{

	// Methods
	public abstract virtual bool IsNewContextOK(Context newCtx) {}
	public abstract virtual void Freeze(Context newContext) {}

	// Properties
	public string Name { get{} }
}

