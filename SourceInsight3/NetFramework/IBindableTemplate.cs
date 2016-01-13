public interface IBindableTemplate : ITemplate
{

	// Methods
	public abstract virtual System.Collections.Specialized.IOrderedDictionary ExtractValues(Control container) {}
}

