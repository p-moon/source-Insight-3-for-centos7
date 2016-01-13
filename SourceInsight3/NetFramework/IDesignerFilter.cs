public interface IDesignerFilter
{

	// Methods
	public abstract virtual void PostFilterAttributes(System.Collections.IDictionary attributes) {}
	public abstract virtual void PostFilterEvents(System.Collections.IDictionary events) {}
	public abstract virtual void PostFilterProperties(System.Collections.IDictionary properties) {}
	public abstract virtual void PreFilterAttributes(System.Collections.IDictionary attributes) {}
	public abstract virtual void PreFilterEvents(System.Collections.IDictionary events) {}
	public abstract virtual void PreFilterProperties(System.Collections.IDictionary properties) {}
}

