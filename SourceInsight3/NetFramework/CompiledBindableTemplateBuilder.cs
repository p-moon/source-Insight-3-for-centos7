public class CompiledBindableTemplateBuilder : IBindableTemplate, ITemplate
{

	// Constructors
	public CompiledBindableTemplateBuilder(BuildTemplateMethod buildTemplateMethod, ExtractTemplateValuesMethod extractTemplateValuesMethod) {}

	// Methods
	public virtual System.Collections.Specialized.IOrderedDictionary ExtractValues(Control container) {}
	public virtual void InstantiateIn(Control container) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

