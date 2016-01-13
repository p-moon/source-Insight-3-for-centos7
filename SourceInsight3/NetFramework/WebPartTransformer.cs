public class WebPartTransformer
{

	// Methods
	public virtual System.Web.UI.Control CreateConfigurationControl() {}
	public abstract virtual object Transform(object providerData) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

