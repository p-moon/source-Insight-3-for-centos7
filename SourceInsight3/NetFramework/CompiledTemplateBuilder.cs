public class CompiledTemplateBuilder : ITemplate
{

	// Constructors
	public CompiledTemplateBuilder(BuildTemplateMethod buildTemplateMethod) {}

	// Methods
	public virtual void InstantiateIn(Control container) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

