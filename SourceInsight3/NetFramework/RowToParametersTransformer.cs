public class RowToParametersTransformer : WebPartTransformer, IWebPartParameters
{

	// Constructors
	public RowToParametersTransformer() {}

	// Methods
	public virtual System.Web.UI.Control CreateConfigurationControl() {}
	public virtual object Transform(object providerData) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string[] ConsumerFieldNames { get{} set{} }
	public string[] ProviderFieldNames { get{} set{} }
}

